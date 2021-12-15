using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ObjectHit : MonoBehaviour
{
    
    public AudioSource AS;
    public GameObject text;
    bool isonplatform;

   private void OnTriggerEnter2D(Collider2D other )
    {
        if (other.gameObject.tag == "Player")
        { 
            AS.Play();
           
        }
    }
    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            isonplatform = true;
            if (isonplatform)
            text.SetActive(true);
        }
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            isonplatform = false;
            if (isonplatform == false)
                text.SetActive(false);
        }
       
    }


}
