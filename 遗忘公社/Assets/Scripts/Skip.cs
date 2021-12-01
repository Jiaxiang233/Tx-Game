using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Skip : MonoBehaviour
{

    public GameObject Changer2;
    public AudioSource audioClip;
    public GameObject pauseMenu;

    public void OnClick()
    {
        Changer2.SetActive(true);
        pauseMenu.SetActive(false);
        audioClip.Play();
        Time.timeScale = 1;
    }
}
