using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MarioMovement : MonoBehaviour
{
    public int playerSpeed = 2;
    private bool facingRight = false;
    public int playerJumpPower = 1250;
    private float moveX;
    private Animator anim;
   

    // Update is called once per frame
    void Update()
    {
        movePlayer();
        anim = GetComponent<Animator>();
    }

    private void movePlayer()
    {
        if (Input.GetButtonDown("Jump")){
            Jump();
          
        }

        moveX = Input.GetAxis("Horizontal");
        if (moveX == 0)
        {
            anim.SetBool("isRunning", false);
        }
        else
        {
            anim.SetBool("isRunning", true);
        }

        if (moveX < 0.0f && facingRight == false)
        {
            FlipPlayer();

        }

        else if( moveX > 0.0f && facingRight == true)
        {
            FlipPlayer();
        }
        gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(moveX * playerSpeed, gameObject.GetComponent<Rigidbody2D>().velocity.y);
    }
    

    private void FlipPlayer()
    {
        facingRight = !facingRight;
        Vector2 localScale = gameObject.transform.localScale;
        localScale.x *= -1;
        transform.localScale = localScale;
    }

    void Jump()
    {
        GetComponent<Rigidbody2D>().AddForce(Vector2.up * playerJumpPower);
    }
}
