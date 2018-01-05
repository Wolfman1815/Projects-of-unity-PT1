using UnityEngine;
using System.Collections;

public class RotationMovement : MonoBehaviour {

	// Use this for initialization
	public float rotationSpeed = 8.0f;
	public float moveSpeed = 2.0f;
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey ("q") && Input.GetKey(KeyCode.LeftControl)) {
			//rotate counter clockwise
			//transform.RotateAround (transform.position, new Vector3 (0f, 0f, 1f), rotationSpeed);
			gameObject.GetComponent<Rigidbody2D> ().angularVelocity = 800;
		}
			if (Input.GetKey ("e") && Input.GetKey(KeyCode.LeftControl)) {
			//rotate counter clockwise
			//transform.RotateAround (transform.position, new Vector3 (0f, 0f, 1f), -rotationSpeed);
			gameObject.GetComponent<Rigidbody2D> ().angularVelocity = 800;
		}

			if (Input.GetKey ("w") && Input.GetKey(KeyCode.LeftControl)) {
			//move forward, which is trasform.up variable
			GetComponent<Rigidbody2D> ().velocity = transform.up * moveSpeed;
		}else{

			//GetComponent<Rigidbody2D> ().velocity = new Vector2 (0f, 0f);

			}
		}
	}