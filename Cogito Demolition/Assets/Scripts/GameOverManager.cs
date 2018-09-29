using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameOverManager : MonoBehaviour {



    public TextMeshProUGUI time;
    public TextMeshProUGUI score;
    public TextMeshProUGUI highScore;
    public TextMeshProUGUI platformCount;
    public TextMeshProUGUI frase;

    // Use this for initialization
    void Start () {

        if(GameManagerController.highScore < GameManagerController.score)
        {
            GameManagerController.highScore = GameManagerController.score;
        }

        print("La score: " + GameManagerController.score);
        print("El tiempo: " + Time.timeSinceLevelLoad);
        print("El piso: " + GameManagerController.platformCount);
        highScore.text = string.Format("{0}", GameManagerController.highScore);
        score.text = string.Format("{0}", GameManagerController.score);
        time.text = string.Format("{0:00.00}", GameManagerController.time);
        platformCount.text = string.Format("{0}", GameManagerController.platformCount);


    }

    // Update is called once per frame
    void Update () {
		
	}




}
