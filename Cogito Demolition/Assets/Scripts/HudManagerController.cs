using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HudManagerController : MonoBehaviour {

    public TextMeshProUGUI time;
    public TextMeshProUGUI score;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        time.text = string.Format("{0:00.00} seg.", Time.time);
        score.text = string.Format("score: {0}", GameManagerController.score);
	}
}
