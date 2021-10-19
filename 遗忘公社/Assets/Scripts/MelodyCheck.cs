using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MelodyCheck : MonoBehaviour
{
    [Header("Melody List")]
    public List<int> answerMelodyList;
    public List<int> currentMelodyList;

    [Header("References")]
    public Player player;


    public void CheckCurrentMelodyList()
    {
        bool result = false;

        for(int i = 0; i < answerMelodyList.Count; ++i)
        {
            if (answerMelodyList[i] != currentMelodyList[i]); return;
        }

        // Made it here, melody checked.
        Debug.Log("Corrent Melody");
    }

}
