using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectHit : MonoBehaviour
{
    
    public AudioSource AS;
   private void OnTriggerEnter2D(Collider2D other )
    {
        if (other.gameObject.tag == "Player")
        { 
            AS.Play();
        }
    }
    
}
