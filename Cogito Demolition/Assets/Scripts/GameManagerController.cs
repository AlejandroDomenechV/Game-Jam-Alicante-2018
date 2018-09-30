using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManagerController : MonoBehaviour {

    public static int score = 0;
    public static int highScore = 0;

    public static int platformCount = 1;
    public int velTimer = 0;

    public static float time = 20.0f;

    private float platformTimer = 2.0f;
    public float timeForPlatform = .75f;

    public float platformVel = 5;

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

        if(platformCount > 30)
        {
            SceneManager.LoadScene("win");
        }

	}

    public void checkTimer()
    {

        time -= Time.deltaTime;
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
            addScorePlatform();
            velTimer++;

            if (velTimer == 5)
            {
                score += 10;
                platformVel += .25f;
                if(time <= 0.0f)
                {
                    score += 20;
                    timeForPlatform -= .3f;
                    time = 20.0f;
                }

                velTimer = 0;
                print("La vel es:" + platform.GetComponent<platformController>().velocity);
            }
            //print("platform count: " + platformCount);
        }
        

    }
    void addScorePlatform()
    {
        score += 5;
    }
}
