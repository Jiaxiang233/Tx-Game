using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockBreak : MonoBehaviour
{
    public GameObject breakblock;
    float time = 0.5f;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            Destroy(GameObject.Find("lol").GetComponent<BoxCollider2D>(), time);
            breakblock.SetActive(false);
        }
    }
} 
