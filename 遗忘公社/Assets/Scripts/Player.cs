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

    [Header("�ƶ�����")]
    public float speed = 8f;

    float xVelocity;

    [Header("��Ծ����")]
    public float jumpForce = 6f;

    int jumpCount;

    [Header("״̬")]
    public bool isOnGround;

    [Header("�������")]
    public LayerMask groundLayer;

    bool jumpPress;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        coll = GetComponent<Collider2D>();
       // transform.position = GameManager.Instance.lastPosition;
        myAnimator = GetComponent<Animator>();
    }


    void Update()
    {
        if (Input.GetButtonDown("Jump") && jumpCount > 0)
        {
            jumpPress = true;
        }
    }

    void FixedUpdate()
    {

        isOnGroundCheck();
        Move();
        Jump();
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
        xVelocity = Input.GetAxisRaw("Horizontal");

        rb.velocity = new Vector2(xVelocity * speed, rb.velocity.y);

        //���淭ת
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

    void Jump()
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
    
}
