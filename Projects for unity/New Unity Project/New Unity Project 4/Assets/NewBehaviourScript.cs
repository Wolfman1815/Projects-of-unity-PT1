using UnityEngine;
using System.Collections;

public class NewBehaviourScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		//if we give random.range an integer, it will return an integer
		//if we give random.range a float, it will return a float
		int roll = Random.Range (1, 20);
		Debug.Log (roll);

		Debug.Log ("you kill anything that is againest the human race");



		if (roll > 19) {
			//we rolled a 20
			Debug.Log ("you stab elite convent in back");
		} else if (roll > 15) {
			//do a thing
			Debug.Log ("you sneak up behind a forrunner and stab it to death");
		}
	}
	
	// Update is called once per frame
	void Update () {
	
		//if we give random.range an integer, it will return an integer
		//if we give random.range a float, it will return a float
		if (Input.GetKeyDown ("space")) {
			int roll = Random.Range (1, 20);
			Debug.Log (roll);
		
			Debug.Log ("you kill anything that is againest the human race");
		



			if (roll > 19) {
				//we rolled a 20
				Debug.Log ("you stab elite convent in back");
			} else if (roll > 15) {
				//do a thing
				Debug.Log ("you sneak up behind a forrunner and stab it to death");
		
			}
		}
	}
}