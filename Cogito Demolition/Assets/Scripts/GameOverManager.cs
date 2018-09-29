using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameOverManager : MonoBehaviour {



    public TextMeshProUGUI time;
    public TextMeshProUGUI score;
    public TextMeshProUGUI platformCount;
    public TextMeshProUGUI frase;

    // Use this for initialization
    void Start () {
        print("La score: " + GameManagerController.score);
        print("El tiempo: " + Time.timeSinceLevelLoad);
        print("El piso: " + GameManagerController.platformCount);
        score.text = string.Format("{0}", GameManagerController.score);
        time.text = string.Format("{0:00.00}", Mathf.Abs(GameManagerController.time));
        platformCount.text = string.Format("{0}", GameManagerController.platformCount);


    }

    // Update is called once per frame
    void Update () {
		
	}




}
