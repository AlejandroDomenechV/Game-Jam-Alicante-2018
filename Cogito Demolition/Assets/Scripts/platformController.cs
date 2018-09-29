using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class platformController : MonoBehaviour {

    public float velocity = 5;
    public float posX = 6.0f;
    public float maxRangeX = 4.3f;
    public float minRangeX = -9.0f;


    // Use this for initialization
    void Start ()
    {
        SetInitPos();
	}
	
	// Update is called once per frame
	void Update ()
    {
        movePlatform();
	}

    public void movePlatform()
    {
        if(transform.position.y < 7f)
        {
            transform.position += new Vector3(0, velocity * Time.deltaTime, 0);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void SetInitPos()
    {
        posX = Random.Range(minRangeX, maxRangeX);
        transform.position = new Vector3(posX, -6.0f, 0);
    }
}
