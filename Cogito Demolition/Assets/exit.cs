using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class exit : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Escape) || Input.GetButtonDown("Cancel"))
        {
            GameManagerController.score = 0;
            GameManagerController.time = 0;
            GameManagerController.platformCount = 1;
            SceneManager.LoadScene("main menu");
        }
    }
}
