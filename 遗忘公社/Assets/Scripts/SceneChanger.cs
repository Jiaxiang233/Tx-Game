using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    public int SceneIndex;

    public Animator transition;

    public float transTime = 1f;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            LoadNextLevel();
        }
    }

    public void LoadNextLevel()
    {
        StartCoroutine(LoadLevel());
    }

    IEnumerator LoadLevel()
    {
        transition.SetTrigger("Start");

        yield return new WaitForSeconds(transTime);

        SceneManager.LoadScene(SceneIndex);
    }
}
