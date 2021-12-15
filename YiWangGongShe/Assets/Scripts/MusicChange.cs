using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicChange : MonoBehaviour
{
    float sec = 0f;
    int i = 1;
    public AudioClip audio1;
    public AudioClip audio2;
    public Sprite image1;
    public Sprite image2;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        sec += Time.deltaTime;
        if (sec / 3 - i < 0.01 && sec / 3 - i > 0)
        {
            i += 1;

            if (i % 2 == 0)
            {
                gameObject.GetComponent<AudioSource>().clip = audio1;
                GameObject.Find("lmao").GetComponent<MelodyCheckBox>().noteIndex = 2;
                GameObject.Find("gg").GetComponent<SpriteRenderer>().sprite = image1;
            
            }
            else
            {
                gameObject.GetComponent<AudioSource>().clip = audio2;
                GameObject.Find("lmao").GetComponent<MelodyCheckBox>().noteIndex = 20;
                GameObject.Find("gg").GetComponent<SpriteRenderer>().sprite = image2;
            }
        }
    }
}
  


