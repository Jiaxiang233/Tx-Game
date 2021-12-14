using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public GameObject pauseMenu;
    public GameObject PauseButton; 
    public GameObject Changer2;
    public GameObject pausemenu;
    public GameObject skipmeun;
    public GameObject musicscore;
    public GameObject musicsocrebackground;
    public GameObject jiepaiqi;
    public GameObject puzibeijing;


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
        musicscore.SetActive(false);
        musicsocrebackground.SetActive(false);
        jiepaiqi.SetActive(false);
        puzibeijing.SetActive(false);
    }
    public void ResumeGame()
    {
        GamePaused = false;
        pauseMenu.SetActive(false);
        PauseButton.SetActive(true);
        musicscore.SetActive(true);
        musicsocrebackground.SetActive(true);
        jiepaiqi.SetActive(true);
        puzibeijing.SetActive(true);
    }
    public void Skip()
    {
        GamePaused = false;
        Changer2.SetActive(true);
        pauseMenu.SetActive(false);
        audioClip.Play();
        Time.timeScale = 1;
    }
    public void skipscene1()
    {
        SceneManager.LoadScene(8);//´ý¶¨
    }
    public void skipscene2()
    {
        SceneManager.LoadScene(12);//´ý¶¨
    }
    public void skip()
    {
        pausemenu.SetActive(false);
        skipmeun.SetActive(true);
    }
    public void returnmenu()
    {
        pausemenu.SetActive(true);
        skipmeun.SetActive(false);
    }
}
