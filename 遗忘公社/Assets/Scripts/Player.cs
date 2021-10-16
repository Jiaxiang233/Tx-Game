using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Player : MonoBehaviour
{
    private Rigidbody2D rb;
    private Collider2D coll;
    public int index;
    public int[] melodyArray = { 1, 2, 3 };
    public int[] currentArray = new int[3];

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
        transform.position = GameManager.Instance.lastPosition;
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

        //镜面翻转
        if (xVelocity != 0)
        {
            transform.localScale = new Vector3(xVelocity, 1, 1);
        }
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
    private void OnCollisionEnter2D(Collision2D collision)
    {
        var block = collision.gameObject.GetComponent<Player>();
        if(block.index == 1)
        {
            int i=1;
            for (int j = 0; j < melodyArray.Length; j++)
            {
                if (currentArray[j] != melodyArray[j])
                {
                    i = 0;
                    Array.Clear(currentArray, 0, currentArray.Length);
                    break;
                }
            }
            if (i == 1)
            {
                Debug.Log("Well Done.");
            }
                
        }
     
        
    }
}
