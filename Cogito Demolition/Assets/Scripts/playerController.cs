﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playerController : MonoBehaviour {


    public float speed = 10f;
    public float maxSpeed = 20f;
    public float jump = 5f;
    private bool IsGrounded;
    private int contbullets;

    public Transform firePoint;
    public GameObject bulletPreFab;
    public bool isFacingRight;

    public Animator animator;

    private SpriteRenderer spriteR;

    private Rigidbody2D rb2d;

    public AudioClip coinSound;
    private AudioSource fuenteAudio;
    // Use this for initialization
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        IsGrounded = true;
        spriteR = GetComponent<SpriteRenderer>();
        fuenteAudio = GetComponent<AudioSource>();
        contbullets = 3;
        isFacingRight = true;
     
    }

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxis("Horizontal");

        rb2d.AddForce(Vector2.right * speed * h);

        animator.SetFloat("speed", Mathf.Abs(h*speed));

        if (rb2d.velocity.x > maxSpeed)
        {
            rb2d.velocity = new Vector2(maxSpeed, rb2d.velocity.y);
        }

        if (rb2d.velocity.x < -maxSpeed)
        {
            rb2d.velocity = new Vector2(-maxSpeed, rb2d.velocity.y);
        }

        //jump
        if (Input.GetKey(KeyCode.UpArrow) && IsGrounded == true)
        {
            rb2d.velocity = new Vector2(rb2d.velocity.x, jump);
            IsGrounded = false;
        }

        if ((Input.GetKeyDown(KeyCode.RightArrow) || Input.GetAxis("Horizontal") > 0.10) && !isFacingRight)
        {
            isFacingRight = true;
            //spriteR.flipX = true;
            transform.Rotate(0f, 180f, 0f);
        }
        else if ((Input.GetKeyDown(KeyCode.LeftArrow) ||Input.GetAxis("Horizontal") < 0) && isFacingRight)
        {
            isFacingRight = false;
            //spriteR.flipX = false;
            transform.Rotate(0f, 180f, 0f);
        }
        if((Input.GetKeyDown(KeyCode.Space) || Input.GetButtonDown("Jump")) && contbullets > 0)
        {
            contbullets--;
            Shoot();
        }

        Debug.Log(Input.GetAxis("Horizontal"));

    }
    void Shoot()
    {
        Instantiate(bulletPreFab, firePoint.position, firePoint.rotation);
    }

    void fixedUpdate()
    {
        //float h = Input.GetAxis("Horizontal");

        // rb2d.AddForce(Vector2.right * speed * h);
        // Debug.Log(rb2d.velocity.x);

    }

    void OnCollisionEnter2D(Collision2D other)
    {
        Debug.Log(IsGrounded);
        if (other.transform.tag == "platforms")
        {
            IsGrounded = true;
            Debug.Log(IsGrounded);
        }
        

    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.GetComponent<Collider2D>().tag == "coin")
        {
            Destroy(collision.gameObject);
            GameManagerController.score += 3;
            fuenteAudio.clip = coinSound;
            fuenteAudio.Play();
        }
        if (collision.transform.tag == "Finish")
        {
            GameManagerController.time = Time.timeSinceLevelLoad;
            SceneManager.LoadScene("game over");
        }

        if (collision.GetComponent<Collider2D>().tag == "enemy") {
            rb2d.AddForce(new Vector2(-10f,0f));
        }
    }


}
