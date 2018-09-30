using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameWinManager : MonoBehaviour {

    public TextMeshProUGUI score;
    public TextMeshProUGUI highScore;
    public TextMeshProUGUI platformCount;
    // Use this for initialization
    void Start () {

        if (GameManagerController.highScore < GameManagerController.score)
        {
            GameManagerController.highScore = GameManagerController.score;
        }

        highScore.text = string.Format("{0}", GameManagerController.highScore);
        score.text = string.Format("{0}", GameManagerController.score);
        platformCount.text = string.Format("{0}", GameManagerController.platformCount - 1);

    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
