using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Player : MonoBehaviour
{
    //���Ҫ�л����ֻ��˲������뽫45,46��87��ע�͵���Ȼ��47-58�У�88��ȡ��ע�ͼ��ɡ�
    private Rigidbody2D rb;
    private Collider2D coll;
    public int index;
    public float playerScale = 0.4f;
    Animator myAnimator;
    public Joystick joystick;
    public bool isonpc ;


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


    public void Update()
    {
        if(isonpc == true)
        {
            pcmovement();
        }
        else
        {
            mobilemovement();
        }
        
        
        //  if (Input.GetButtonDown("Jump") && jumpCount > 0)
       //             jumpPress = true;                                  //���Զ˲���
      //Touch touch = Input.GetTouch(1);                               //�ֻ��˲���
      // for(int i = 0;i<Input.touchCount; i++)
      // {
      //      Vector3 pos = Input.GetTouch(i).position;
      //      if (pos.x > Screen.width / 2)
      //      {
      //          if (touch.phase == TouchPhase.Began && jumpCount > 0)
      //          {
      //              jumpPress = true;
      //          }
      //      }
      //  }

    }

    void pcmovement()
    {
        if (Input.GetButtonDown("Jump") && jumpCount > 0 && isonpc)
            jumpPress = true;
    }
    void mobilemovement()
    {
        Touch touch = Input.GetTouch(1);                               //�ֻ��˲���
         for(int i = 0;i<Input.touchCount; i++)
         {
              Vector3 pos = Input.GetTouch(i).position;
             if (pos.x > Screen.width / 2)
              {
                  if (touch.phase == TouchPhase.Began && jumpCount > 0)
                {
                     jumpPress = true;
                 }
              }
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
        if (isonpc == true)
        {
            xVelocity = Input.GetAxisRaw("Horizontal");
        }                                                       //���Զ˲���
        else
        {
            xVelocity = joystick.Horizontal;
        }                                                       //�ֻ��˲���
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
