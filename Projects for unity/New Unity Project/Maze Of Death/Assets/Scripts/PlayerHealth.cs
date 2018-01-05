using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour {


	public int health = 10;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (health <= 0) {
			//reload the scene if player health is equal to or less than 0
			Scene scene = SceneManager.GetActiveScene();
			SceneManager.LoadScene (scene.name);
		}
	}

	void OnCollisionEnter2D(Collision2D collision){
		if (collision.gameObject.tag == "enemy" ) {
			//when the player runs into an enemy, reduce the player health by 1 
			health--;
		}
	}
}
