using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Player : MonoBehaviour
{
    private Rigidbody2D rb;
    private Collider2D coll;
    public int index;
    public float playerScale = 0.4f;
    Animator myAnimator;
    public Joystick joystick;
    [Header("移动参数")]
    public float speed = 8f;

    float xVelocity;

    [Header("跳跃参数")]
    public float jumpForce = 6f;

    int jumpCount;

    [Header("状态")]
    public bool isOnGround;

    [Header("环境检测")]
    public LayerMask groundLayer;

    bool jumpPress;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        coll = GetComponent<Collider2D>();
       // transform.position = GameManager.Instance.lastPosition;
        myAnimator = GetComponent<Animator>();

    }


    public void Update()
    {
         if (Input.GetButtonDown("Jump") && jumpCount > 0) //电脑端操作
       // if (joystick.Vertical>0.5f && jumpCount > 0) //手机端操作
       
        {
            jumpPress = true;
        }
    }
   

    public void FixedUpdate()
    {

        isOnGroundCheck();
        Move();
        Jump();
        SwitchAnim();
     
    }

    void isOnGroundCheck()
    {
        if (coll.IsTouchingLayers(groundLayer))
        {
            isOnGround = true;
        }
        else
        {
            isOnGround = false;
        }
    }

    void Move()
    {
         xVelocity = Input.GetAxisRaw("Horizontal");//电脑端操作
        //xVelocity = joystick.Horizontal;  //手机端操作
        rb.velocity = new Vector2(xVelocity * speed, rb.velocity.y);

        //镜面翻转
        if (xVelocity != 0)
        {
            transform.localScale = new Vector3(playerScale*xVelocity, playerScale, playerScale);
        }
        bool i;
        if (rb.velocity.x != 0)
            i = true;
        else
            i = false;
        myAnimator.SetBool("isMoving", i);

    }

    public void Jump()
    {
        if (isOnGround)
        {
            jumpCount = 1;
        }
        if (jumpPress && isOnGround)
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpForce);
            jumpCount--;
            jumpPress = false;
        }
        else if (jumpPress && jumpCount > 0 && !isOnGround)
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpForce);
            jumpCount--;
            jumpPress = false;
        }
    }
    void SwitchAnim()
    {
        if (isOnGround)
            myAnimator.SetBool("isJumping", false);
        else
            myAnimator.SetBool("isJumping", true);
    }


     
   
    
}
