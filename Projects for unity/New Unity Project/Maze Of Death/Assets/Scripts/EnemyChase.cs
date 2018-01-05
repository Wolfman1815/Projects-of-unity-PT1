using UnityEngine;
using System.Collections;

public class EnemyChase : MonoBehaviour {

	public GameObject target;
	public float chaseSpeed = 9.5f;
	public float chaseTriggerDistance = 2.0f;
	private bool home = true;
	private Vector3 homePosition;
	public Vector3 paceDirection = new Vector3 (0f, 0f, 0f);
	public float maxMoveDistance = 10.0f;
	public float walkingSpeed = 1.0f;
	// Use this for initialization
	void Start () {
		//get the spawn position so we know how to get home
		homePosition = transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 playerPosition = target.transform.position;
		Vector2 chaseDirection = new Vector2 (playerPosition.x - transform.position.x, playerPosition.y - transform.position.y);


		//chase the player, leaving home behind
		if (chaseDirection.magnitude < chaseTriggerDistance) {
			home = false;
			chaseDirection.Normalize ();
			GetComponent<Rigidbody2D> ().velocity = chaseDirection * chaseSpeed;
		} else if (home == false) {
			//if we're not home, we need to go home
			Vector3 goHome = homePosition - transform.position;
			if (goHome.magnitude < 0.1f) {
				//we have arrived at home
				home = true;
				GetComponent<Rigidbody2D> ().velocity = new Vector2 (0, 0);
			} else {
				goHome.Normalize ();
				GetComponent<Rigidbody2D> ().velocity = goHome * walkingSpeed;

				}
			}else{
			Vector3 dispalcement = transform.position - homePosition;
			float distanceFromHome = dispalcement.magnitude;
			if(distanceFromHome >= maxMoveDistance) {
				paceDirection = -dispalcement;
		}
			paceDirection.Normalize ();
			GetComponent<Rigidbody2D> ().velocity = paceDirection * walkingSpeed;
		}
	}
}