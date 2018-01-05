using UnityEngine;
using System.Collections;

public class FindObjects : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		//we want to find all of the enemy objects, and store them in an array
		GameObject[] store = GameObject.FindGameObjectsWithTag("enemy");
		Debug.Log (store.Length);
		if(store.Length == 0) {
			//all the enemies are dead, laod the win screen
		}
	}
}