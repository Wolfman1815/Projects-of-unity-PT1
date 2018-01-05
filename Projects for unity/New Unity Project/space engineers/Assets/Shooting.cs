using UnityEngine;
using System.Collections;

public class Shooting : MonoBehaviour {

	public GameObject prefab;
	public float shootspeed = 10.0f;
	// Use this for initialization
	void Start () {

	}
	// Update is called once per frame
	void Update () {

		if(Input.GetButton ("Fire1")) {
			//fire ze missiles
			//Debug.Log("boom");
			GameObject bullet = (GameObject) Instantiate (prefab, transform.position, Quaternion.identity);

			//gets the mouse position in pixels on the screen
			var mousePosition = Input.mousePosition;
			//converts the mouse position from pixels to x,y,z position in the game
			mousePosition = Camera.main.ScreenToWorldPoint (mousePosition);
			//calculate the shoot direction as mouse position - player position
			Vector2 shootDirection = new Vector2 (mousePosition.x - transform.position.x, mousePosition.y - transform.position.y);
			//make the shoot direction vector length always be 1
			shootDirection.Normalize ();

			bullet.GetComponent<Rigidbody2D> ().velocity = shootDirection * shootspeed;
		}
	}
}