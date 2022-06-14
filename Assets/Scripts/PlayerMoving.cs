using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMoving : MonoBehaviour
{
    public bool isGrounded;
    public float jumpForce;
    public float speed;
    public Rigidbody2D rb;

    void OnCollisionEnter2D()
    {
        isGrounded = true;
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.D))
        {
            rb.velocity = new Vector2(speed, rb.velocity.y);
        }
        if (Input.GetKey(KeyCode.A)) 
        {
            rb.velocity = new Vector2(-speed, rb.velocity.y);
        }

        if (Input.GetKey(KeyCode.W) && isGrounded) 
        {
            isGrounded = false;
            GetComponent<Rigidbody2D>().AddForce((transform.up * jumpForce), ForceMode2D.Impulse);            
        }
    }
   
}
