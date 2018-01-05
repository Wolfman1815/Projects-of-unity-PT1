using UnityEngine;
using System.Collections;


public class enemyHealth : MonoBehaviour {



	public int health = 10;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (health <= 0)  {
			Destroy (this.gameObject);
			//reload the scene if player health is equal to or less than 0
		}
	}

	void OnCollisionEnter2D(Collision2D collision){
		if (collision.gameObject.name == "Player" || collision.gameObject.name == "Bullet(Clone)") {
			//when the player runs into an enemy, reduce the player health by 1 
			health--;
			Debug.Log (health);

		}
	}
}