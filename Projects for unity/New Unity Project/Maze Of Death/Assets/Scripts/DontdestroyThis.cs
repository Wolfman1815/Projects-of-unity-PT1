using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class DontdestroyThis : MonoBehaviour {

	// Use this for initialization
	public string level;
	void Start () {
		DontDestroyOnLoad (this.gameObject);
	}
	
	// Update is called once per frame
	void Update () {
		//when we load the actual game, we need to kill this object
		if (SceneManager.GetActiveScene ().name == level){
			Destroy (this.gameObject);
		}
	}
}