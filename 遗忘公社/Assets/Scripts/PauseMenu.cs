using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    public GameObject pauseMenu;
    public GameObject PauseButton; 
    public GameObject Changer2;

    public AudioSource audioClip;

    bool GamePaused;
    // Start is called before the first frame update
    void Start()
    {
        GamePaused = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (GamePaused)
            Time.timeScale = 0;
        else
            Time.timeScale = 1;
    }
    public void PauseGame()
    {
        GamePaused = true;
        pauseMenu.SetActive(true);
        PauseButton.SetActive(false);
    }
    public void ResumeGame()
    {
        GamePaused = false;
        pauseMenu.SetActive(false);
        PauseButton.SetActive(true);
    }
    public void Skip()
    {
        GamePaused = false;
        Changer2.SetActive(true);
        pauseMenu.SetActive(false);
        audioClip.Play();
        Time.timeScale = 1;
    }
}
