using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManagerController : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void startCinematica() {
        SceneManager.LoadScene("Cinematica");
    }
    public void startGame()
    {
        GameManagerController.score = 0;
        GameManagerController.time = 0;
        GameManagerController.platformCount = 1;
        SceneManager.LoadScene("game");
    }
    public void closeGame()
    {
        Application.Quit();
    }
    public void goToMenu()
    {
        SceneManager.LoadScene("main menu");
    }
}
