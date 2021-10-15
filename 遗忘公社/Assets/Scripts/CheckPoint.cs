using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPoint : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.transform.tag=="Player")
        {
            GameManager.Instance.lastPosition = transform.position;
        }
    }
}
