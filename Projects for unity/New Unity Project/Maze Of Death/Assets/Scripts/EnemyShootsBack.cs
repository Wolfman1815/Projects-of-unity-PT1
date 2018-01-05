using UnityEngine;
using System.Collections;

public class EnemyShootsBack : MonoBehaviour {

	// Use this for initialization
	public GameObject prefab;
	public float bulletSpeed = 10f;
	public float shootTriggerDistance = 5f;
	public GameObject target;
	public float shootDelay = 3f;
	float totalTime = 0;
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		totalTime += Time.deltaTime;
		Vector2 shootDirection = new Vector2 (target.transform.position.x - transform.position.x,
			                         target.transform.position.y - transform.position.y);
		float shootDistance = shootDirection.magnitude;
		if(shootTriggerDistance >= shootDistance && totalTime >= shootDelay) {
			//stu would shoot at me
			totalTime = 0;
			shootDirection.Normalize();
			Vector3 spawnPosition = transform.position;
			spawnPosition.x += shootDirection.x * 0.5f;
			spawnPosition.y += shootDirection.y * 0.5f;
			GameObject EnemyBullet = (GameObject) Instantiate (prefab, spawnPosition, Quaternion.identity);
			EnemyBullet.GetComponent<Rigidbody2D> ().velocity = shootDirection * bulletSpeed;
			Destroy (EnemyBullet, 1.0f);
		}
	}
}