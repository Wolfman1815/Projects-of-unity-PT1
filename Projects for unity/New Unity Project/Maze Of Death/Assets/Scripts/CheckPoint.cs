using UnityEngine;
using System.Collections;

public class CheckPoint : MonoBehaviour {

	// Use this for initialization
	Vector3 checkpoint = new Vector3 (0, 0, 0);
	void Start () {
		checkpoint = gameObject.transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		if (PlayerPrefs.GetInt ("Health") <= 0) {
			gameObject.transform.position = checkpoint;
			PlayerPrefs.SetInt ("Health", 400);
			PlayerPrefs.SetInt ("Lives", PlayerPrefs.GetInt ("Lives") - 1);
		}
	}
	void OnTriggerEnter2D(Collider2D collider){
		if (collider.gameObject.name == "Checkpoint") {
			checkpoint = collider.gameObject.transform.position;
			}
		}
	}
