using UnityEngine;
using System.Collections;

public class looping : MonoBehaviour {

	// Use this for initialization
	void Start () {
		int numofenemies = 3;
		for (int i = 1; i < numofenemies; i++) {
			Debug.Log ("creating enemy number " + i);
		}

		int cupsInSink = 4;
		while (cupsInSink > 0) {
			Debug.Log ("I washed a cup!");
			cupsInSink --;
			//cupsInSink = cupsInSink -1;
			//cupsInSink -=1;
		}
			
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
