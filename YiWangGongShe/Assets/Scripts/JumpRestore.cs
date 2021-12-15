using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpRestore : MonoBehaviour
{
    public float jumprestore;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            GameObject.Find("Player").GetComponent<Player>().jumpForce = jumprestore;
        }
    }
}
