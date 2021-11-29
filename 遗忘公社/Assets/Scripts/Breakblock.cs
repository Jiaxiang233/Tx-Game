using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Breakblock : MonoBehaviour
{
    public GameObject breaks;
    float time = 0.5f;

    public void breakblock()
    {
        Destroy(breaks.GetComponent<BoxCollider2D>(), time);
        //  breaks.SetActive(false);
    }
}
