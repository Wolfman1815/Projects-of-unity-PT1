﻿using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class ButtonLoad1 : MonoBehaviour {

	// Use this for initialization
	public string level;
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}


	public void OnButtonClick(){
		SceneManager.LoadScene (level);
	}
}
