﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CreaditsManagerController : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKey(KeyCode.Escape) || Input.GetButtonDown("Cancel"))
        {
            SceneManager.LoadScene("main menu");
        }
	}
}
