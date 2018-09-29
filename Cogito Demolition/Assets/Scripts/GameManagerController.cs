using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManagerController : MonoBehaviour {

    public int platformCount = 1;
    public int velTimer = 0;

    private float platformTimer = 2.0f;
    public float timeForPlatform = .75f;

    public int platformVel = 5;

    GameObject platform;

	// Use this for initialization
	void Start ()
    {
        platformTimer = timeForPlatform;
    }
	
	// Update is called once per frame
	void Update ()
    {
        checkTimer();
	}

    public void checkTimer()
    {
        platformTimer -= Time.deltaTime;

        if (platformTimer < 0)
        {
            platform = Instantiate(GameObject.FindGameObjectWithTag("platforms"));
            platformTimer = timeForPlatform;
            //platform.GetComponent<platformController>().velocity = platformVel;

            for(int i = 0; i < GameObject.FindGameObjectsWithTag("platforms").Length; i++)
            {
                GameObject.FindGameObjectsWithTag("platforms")[i].GetComponent<platformController>().velocity = platformVel;
            }


            platformCount++;
            velTimer++;

            if (velTimer == 5)
            {
                platformVel++;
                timeForPlatform -= .05f;
                
                velTimer = 0;
                print("La vel es:" + platform.GetComponent<platformController>().velocity);
            }
            //print("platform count: " + platformCount);
        }
        

    }
}
