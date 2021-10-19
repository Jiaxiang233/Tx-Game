using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MelodyCheckBox : MonoBehaviour
{
    
    public int noteIndex = 0; // Set this in inspector

    void OnTriggerEnter2D(Collision2D coll)
    {
        if(coll.gameObject.name == "Player") // Use tag here rather than name
        {
            var player = coll.gameObject;
            var melodyCheck = player.GetComponent<MelodyCheck>();
            melodyCheck.currentMelodyList.Add(noteIndex);
            melodyCheck.CheckCurrentMelodyList();
        }
    }
}
