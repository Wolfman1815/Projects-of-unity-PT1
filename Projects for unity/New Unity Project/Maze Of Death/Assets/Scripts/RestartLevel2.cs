using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class RestartLevel2 : MonoBehaviour {

	public int health = 10;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (health <= 0) {
			//loads restart scene when player health at 0
			//Scene scene = SceneManager.GetActiveScene ();
			SceneManager.LoadScene ("RestartLevel2");
		}
	}
	void OnCollisionEnter2D(Collision2D collision){
		if (collision.gameObject.tag == "enemy" ) {
			//when the player runs into an enemy, reduce the player health by 1 
			health--;

		}
	}
}