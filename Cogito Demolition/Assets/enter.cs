﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class enter : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Return) || Input.GetButtonDown("Submit")) {
            GameManagerController.score = 0;
            GameManagerController.time = 0;
            GameManagerController.platformCount = 1;
            SceneManager.LoadScene("game");
        }
		
	}
}
