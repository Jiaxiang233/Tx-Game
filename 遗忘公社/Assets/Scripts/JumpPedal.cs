using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpPedal : MonoBehaviour
{
    public float jump;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            GameObject.Find("Player").GetComponent<Player>().jumpForce = jump;
        }
    }
}
