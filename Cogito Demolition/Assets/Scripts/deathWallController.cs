using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deathWallController : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(Time.timeSinceLevelLoad < 2)
        {
            gameObject.GetComponent<BoxCollider2D>().enabled = false;
        }
        else
            gameObject.GetComponent<BoxCollider2D>().enabled = true;
    }
}
