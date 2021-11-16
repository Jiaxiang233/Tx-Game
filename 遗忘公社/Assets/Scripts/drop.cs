using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class drop : MonoBehaviour
{
    bool triggered = false;
    public GameObject Player;
    public GameObject image;
    //加上player子物体时斜着跳或者水平移动会多次碰撞检测，不加平台下落速度与玩家不一致则脚会鬼畜


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (triggered)
        {
            this.transform.Translate(0, -2f * Time.deltaTime, 0);
        }
    }

    //碰到时触发，结束碰撞不触发。stay不能用，原因未知。
    void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("Entered");
        if (other.gameObject.tag == "Player")
        {
            triggered = true;
            Player.transform.parent = transform;
            image.transform.parent = transform;
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {

        Debug.Log("Exited");
        if (other.gameObject.tag == "Player")
        {
            triggered = false;
            Player.transform.parent = null;
            image.transform.parent = null;

        }
    }
    }
