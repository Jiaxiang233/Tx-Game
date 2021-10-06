using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectHit : MonoBehaviour
{
    public AudioSource AS;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        AS.Play();
    }
}
