using UnityEngine;
using System.Collections;

public class NewBehaviourScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		int variable = 10;
		Debug.Log (variable);
		variable = variable + 1;
		Debug.log (variable);
		variable += 1;
		Debug.Log ("HelloWorld!");
	}
}
