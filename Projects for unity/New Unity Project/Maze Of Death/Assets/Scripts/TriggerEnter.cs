using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class TriggerEnter : MonoBehaviour {

	// Use this for initialization
	public string levelToLoad;
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		}

	void OnTriggerEnter2D(Collider2D collider){
		if (collider.name == "Player") {
			SceneManager.LoadScene (levelToLoad);
			}
		}
	}