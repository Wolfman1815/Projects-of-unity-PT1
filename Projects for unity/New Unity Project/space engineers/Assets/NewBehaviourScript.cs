using UnityEngine;
using System.Collections;

public class NewBehaviourScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		Vector3 position = transform.position;
		if (Input.GetKey ("w")) {
		//move in the positive y direction	
			position.y +=1;
	}
		if (Input.GetKey ("s")) {
			//move in the Negative y direction	
			position.y -=1;
		}
		if (Input.GetKey ("d")) {
			//move in the positive x direction	
			position.x +=1;
			}

		if (Input.GetKey ("a")) {
			//move in the Negative x direction	
			position.x -=1;
		}
		transform.position = position;
	}
}