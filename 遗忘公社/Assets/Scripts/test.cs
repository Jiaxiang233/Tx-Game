using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour
{
    float sec=0f;
    int i=1;
    public AudioClip audio1;
    public AudioClip audio2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        sec += Time.deltaTime;
        if (sec%3 == 0 )
        {
            i += 1;
         
            if (i%2 == 0 )
            {
                gameObject.GetComponent<AudioSource>().clip = audio1;
                GameObject.Find("lol").GetComponent<MelodyCheckBox>().noteIndex = 2;
            }
            else
                gameObject.GetComponent<AudioSource>().clip = audio2;
                GameObject.Find("lol").GetComponent<MelodyCheckBox>().noteIndex = 20;
        }
    }
 
    
}
