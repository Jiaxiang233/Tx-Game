using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MelodyCheck : MonoBehaviour
{
    [Header("Melody List")]
    public int answerLength;
    public List<int> answerMelodyList;  // Fixed Length
    public List<int> currentMelodyList;

    public void CheckCurrentMelodyList()
    {

        // Should Not Happen
        if (currentMelodyList.Count == 0) return;

        for(int i = 0; i < currentMelodyList.Count; ++i)
        {
            if (answerMelodyList[i] != currentMelodyList[i])
            {
                // Check Failed
                Debug.Log("Check Fail, Clear the currentMelodyList");
                currentMelodyList.Clear();
                return;
            }
        }

        // Check Success
        Debug.Log("Corrent Melody is Same");
        // Check If Complete
        if(currentMelodyList.Count == answerMelodyList.Count)
        {
            // Reach The End
            Debug.Log("-- Melody Complete");
            currentMelodyList.Clear();

            // Some Other Logic
        }

    }

}
