using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MelodyCheckBox : MonoBehaviour
{
    
    public int noteIndex = 0; // Set this in inspector

    void OnTriggerEnter2D(Collider2D coll)
    {
        if(coll.gameObject.name == "Player") // Use tag here rather than name
        {
            var player = coll.gameObject;
            var melodyCheck = player.GetComponent<MelodyCheck>();
            melodyCheck.currentMelodyList.Add(noteIndex);
            melodyCheck.CheckCurrentMelodyList();
            Debug.Log("Check Player");
        }
    }

    
}
