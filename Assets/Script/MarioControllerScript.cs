using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MarioControllerScript : MonoBehaviour {

    public float speed = 1.0f;
    public float jumpSpeed = 1.0f;
    private Rigidbody2D mario;
    private Animator marioAnimation;
    private bool facingRight = true;

    public LayerMask groundLayer;
    private Transform groundCheck;
    private Transform gCheck;

    void Start () {
        mario = GetComponent<Rigidbody2D>();
        marioAnimation = GetComponent<Animator>();
        groundCheck = transform.Find("GroundCheck");

    }
	
	void FixedUpdate () {
        float marioSpeed = Input.GetAxis("Horizontal");
        marioAnimation.SetFloat("Speed", Mathf.Abs(marioSpeed));

        bool isGrounded = Physics2D.OverlapPoint(groundCheck.position, groundLayer);

        //Debug.Log(groundCheck.position);
        //Debug.Log(isGrounded);

        marioAnimation.SetBool("isGrounded", isGrounded);

        if (Input.GetKey(KeyCode.Space))
        {
            if (isGrounded)
            {
                mario.AddForce(Vector2.up * jumpSpeed, ForceMode2D.Force);
                isGrounded = false;
            }
        }

        this.mario.velocity = new Vector2(marioSpeed * speed, this.mario.velocity.y);

        if (marioSpeed > 0 && !facingRight)
        {
            Flip();
        }
        else if (marioSpeed < 0 && facingRight)
        {
            Flip();
        }

    }

    void Flip()
    {
        facingRight = !facingRight;
        Vector3 theScale = transform.localScale;
        theScale.x *= -1;
        transform.localScale = theScale;
    }
}
