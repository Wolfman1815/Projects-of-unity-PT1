using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyLook : MonoBehaviour {

	// Use this for initialization
	public GameObject player;
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.forward = player.transform.position - transform.position;
	}
}
