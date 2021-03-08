using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MarioMovement : MonoBehaviour
{
    public float JumpForce = 5f;
    public float moveSpeed = 5f;
    //public bool isGrounded = false;
    private Rigidbody2D rb;
    private Animator anim;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }
    void Update()
    {
        var movement = Input.GetAxis("Horizontal");
        transform.position += new Vector3(movement, 0f, 0f) * Time.deltaTime * moveSpeed;
        if (movement == 0)
        {
            anim.SetBool("isRunning", false);
        }
        else
        {
            anim.SetBool("isRunning", true);
            anim.SetBool("isJumping", false);
        }

        if (!Mathf.Approximately(0, movement))
            transform.rotation = movement < 0 ? Quaternion.Euler(0, 180, 0) : Quaternion.identity;



        if (Input.GetButtonDown("Jump") && Mathf.Abs(rb.velocity.y) < 0.001f)
        {
            rb.AddForce(new Vector2(0, JumpForce), ForceMode2D.Impulse);
            anim.SetBool("isJumping", false);
        }
        else if(rb.velocity.y > 0.001f)
        {
            anim.SetBool("isJumping", true);
            anim.SetBool("isRunning", false);
        }
        
        

        
    }
    

   
}
