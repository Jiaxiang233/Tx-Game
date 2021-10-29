using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class drop : MonoBehaviour
{
    bool triggered = false;
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
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {

        Debug.Log("Exited");
        if (other.gameObject.tag == "Player")
        {
            triggered = false;
        }
    }
    }
