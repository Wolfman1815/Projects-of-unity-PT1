using UnityEngine;
using System.Collections;

public class forcemovement : MonoBehaviour {
	// Use this for initialization

	public float speed = 0.1f;

	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {


		Vector2 move = new Vector2 (0, 0);
		if (Input.GetKey ("a")) {

			move.x = -speed;
		}
			if (Input.GetKey ("w")) {
				//move in the positive y direction	
				move.y = speed;
			}
			if (Input.GetKey ("s")) {
				//move in the Negative y direction	
				move.y = -speed;
			}
			if (Input.GetKey ("d")) {
				//move in the positive x direction	
				move.x = speed;
			}


		GetComponent<Rigidbody2D> ().velocity = move;
	
	}
}
