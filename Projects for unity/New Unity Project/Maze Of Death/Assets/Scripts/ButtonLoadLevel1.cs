﻿using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class ButtonLoadLevel1 : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

	}


	public void OnButtonClick(){
		SceneManager.LoadScene ("Novement");
	}
}
