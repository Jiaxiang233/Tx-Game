using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BreakblockCheckbox : MonoBehaviour
{
    public GameObject breaks;//·½¿é

    private void OnTriggerEnter2D(Collider2D other)
    {
        var player = breaks;
        var block = player.GetComponent<Breakblock>();
        if (other.gameObject.tag == "Player")
        {
            block.breakblock();
        }
    }
}
