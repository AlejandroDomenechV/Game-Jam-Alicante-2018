using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{

    public float speed = 20f;
    public Rigidbody2D rb;

    // Use this for initialization
    void Start()
    {
        rb.velocity = transform.right * speed;

    }
    void Update()
    {
        transform.Rotate(Vector3.forward * 10);   
    }

    void OnTriggerEnter2D(Collider2D obg)
    {

        enemy_ai enemy = obg.GetComponent<enemy_ai>();

        if (enemy != null)
        {
            Destroy(obg.gameObject);
        }
    }

}
