using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MelodyCheck : MonoBehaviour
{
    [Header("Melody List")]
    public List<int> answerMelodyList;  // Fixed Length
    public List<int> currentMelodyList;

    public Vector3 position;

    public GameObject SceneChanger;

    public AudioSource audioClip;

    public Animator transition;

    public int sceneindex;
    public float transTime = 1f;

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
                MusicScore.Instance.ScoreRes();
                //DestroyImmediate(gameObject);
                //gameObject.transform.position = position;
                ReloadLevel();
                return;
            }
        }

        // Check Success
        Debug.Log("Corrent Melody is Same");
        MusicScore.Instance.ScoreMove(1);
        // Check If Complete
        if (currentMelodyList.Count == answerMelodyList.Count)
        {
            // Reach The End
            Debug.Log("-- Melody Complete");
            audioClip.Play();
            SceneChanger.SetActive(true);


            // Some Other Logic
        }

    }
    public void ReloadLevel()
    {
        StartCoroutine(LoadLevel());
    }

    IEnumerator LoadLevel()
    {
        transition.SetTrigger("Start");

        yield return new WaitForSeconds(transTime);

        SceneManager.LoadScene(sceneindex);
    }


}
