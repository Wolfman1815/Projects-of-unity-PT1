using UnityEngine;
using System.Collections;

public class Timer : MonoBehaviour {

	private float totalTime = 0f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		//change in time since the last frame was
		//loaded
		totalTime += Time.deltaTime;
		float TotalTime = Time.deltaTime;
		Debug.Log (totalTime);

		if (totalTime >= 10) {
			//do a thing

			//if we want to repeat the process every
		   // x seconds, we can rest totalTime
			totalTime = 0;
		}
	}
}
