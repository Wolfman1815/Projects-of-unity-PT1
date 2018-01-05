using UnityEngine;
using System.Collections;

public class AnimataorControl : MonoBehaviour {

	// Use this for initialization
	private Animator animator;
	void Start () {
		animator = GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown("w")){
			animator.SetBool ("Up", true);
			animator.SetBool ("Down", false);
			animator.SetBool ("Left", false);
			animator.SetBool ("Right", false);
	}
		if(Input.GetKeyDown("s")){
			animator.SetBool ("Up", false);
			animator.SetBool ("Down", true);
			animator.SetBool ("Left", false);
			animator.SetBool ("Right", false);
		}
		if(Input.GetKeyDown("a")){
			animator.SetBool ("Up", false);
			animator.SetBool ("Down", false);
			animator.SetBool ("Left", true);
			animator.SetBool ("Right", false);
		}
		if(Input.GetKeyDown("d")){
			animator.SetBool ("Up", false);
			animator.SetBool ("Down", false);
			animator.SetBool ("Left", false);
			animator.SetBool ("Right", true);
		}

		if(!Input.GetKey("s") && !Input.GetKey("w") && !Input.GetKey("a") && !Input.GetKey("d")) {
				animator.SetBool ("Up", false);
				animator.SetBool ("Down", false);
				animator.SetBool ("Left", false);
				animator.SetBool ("Right", false);
			}
		}
	}