﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour {

    public float speed = 10f;
    public float maxSpeed = 20f;
    public float jump = 5f;
    private bool IsGrounded;

    private Rigidbody2D rb2d;
    // Use this for initialization
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        IsGrounded = true;
    }

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxis("Horizontal");

        rb2d.AddForce(Vector2.right * speed * h);

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

}
