using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cinematica : MonoBehaviour {
    public float speed = 10.0F; //Velocidad de movimiento
                                // Use this for initialization
    Rigidbody2D myRB;
    public Animator animator;

    private SpriteRenderer spriteR;

    void Start () {
        myRB = GetComponent<Rigidbody2D>();
        spriteR = GetComponent<SpriteRenderer>();
    }
	
	// Update is called once per frame
	void Update () {
        if (Time.timeSinceLevelLoad < 3.0f)
        {
            myRB.velocity = new Vector2(-1 * 70, myRB.velocity.y);
        }
        else
        {
            myRB.velocity = new Vector2(0, 0);
            animator.SetFloat("speed", Time.timeSinceLevelLoad);
            if (Time.timeSinceLevelLoad > 5.5f)
                GameObject.FindGameObjectWithTag("bomba").GetComponent<SpriteRenderer>().enabled = true;
            if (Time.timeSinceLevelLoad > 6.5f) { 
                spriteR.flipX = true;
                myRB.velocity = new Vector2(0, 0);
                myRB.velocity = new Vector2(1 * 90, myRB.velocity.y);
            }
        }
       
    }
}
