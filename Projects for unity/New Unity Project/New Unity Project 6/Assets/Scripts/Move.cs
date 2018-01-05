using UnityEngine;
using System.Collections;

public class Move : MonoBehaviour {

	// Use this for initialization
	public float speed = 0.1f;

	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		Vector3 position = transform.position;
		if (Input.GetKey ("w")) {
		//move in the positive y direction	
			position.y += speed;
	}
		if (Input.GetKey ("s")) {
			//move in the Negative y direction	
			position.y -= speed;
		}
		if (Input.GetKey ("d")) {
			//move in the positive x direction	
			position.x += speed;
			}

		if (Input.GetKey ("a")) {
			//move in the Negative x direction	
			position.x -= speed;
		}
		transform.position = position;
	}
}