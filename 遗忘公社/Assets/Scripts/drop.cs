using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class drop : MonoBehaviour
{
    bool triggered = false;
    public GameObject Player;
    public GameObject image;
    //����player������ʱб��������ˮƽ�ƶ�������ײ��⣬����ƽ̨�����ٶ�����Ҳ�һ����Ż����


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

    //����ʱ������������ײ��������stay�����ã�ԭ��δ֪��
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
