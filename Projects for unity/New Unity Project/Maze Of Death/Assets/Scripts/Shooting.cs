using UnityEngine;
using System.Collections;

public class Shooting : MonoBehaviour {

	public GameObject prefab;
	public float shootSpeed = 10.0f;

	// Use this for initialization
	void Start () {
	}
	// Update is called once per frame
	void Update () {
		if(Input.GetButton ("Fire1")) {

			//gets the mouse position in pixels on the screen
			var mousePosition = Input.mousePosition;
			//converts the mouse position from pixels to x,y,z position in the game
			mousePosition = Camera.main.ScreenToWorldPoint (mousePosition);
			//calculate the shoot direction as mouse position - player position
			Vector2 shootDirection = new Vector2 (mousePosition.x - transform.position.x, mousePosition.y - transform.position.y);
			//make the shoot direction vector lenght always be 1
			shootDirection.Normalize ();


			//get the player position, and adds the shoot direction to it so we will spawn the bullet a little bit
			//in front of the player, towards the mouse
			Vector3 playerPosition = transform.position;
			playerPosition.x += shootDirection.x * 4.5f;
			playerPosition.y += shootDirection.y * 4.5f;


			//create the object in front of the player , shooting towarda the mouse
			GameObject bullet = (GameObject) Instantiate (prefab, playerPosition, Quaternion.identity);
			bullet.GetComponent<Rigidbody2D> ().velocity = shootDirection * shootSpeed;

		}
	}
}