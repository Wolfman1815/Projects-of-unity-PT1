using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TypeText : MonoBehaviour {

	// Use this for initialization
	public string [] conversation;

	int conversationIndex = 0;
	string text;
	float totalTime = 0;
	int charCount = 0;
	public float textSpeed = 0.1f;
	void Start () {
		//we are assuming we are attaching this script to a text object
		text = gameObject.GetComponent<Text> ().text;
	}
	
	// Update is called once per frame
	void Update () {
		text = conversation [conversationIndex];
		totalTime += Time.deltaTime;
		if(totalTime >= textSpeed && charCount < text.Length) {
			//if our time is greater than or equal to the time interval
			//do the thing
			charCount += 1;
			totalTime = 0;
		}
		string words = text.Substring (0, charCount);
		gameObject.GetComponent<Text> ().text = words;
	}
	public void onButtonClick(){
		conversationIndex++;
		charCount = 0;
	}
}
