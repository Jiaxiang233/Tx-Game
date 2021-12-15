using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class justtest : MonoBehaviour
{
    float i;
    public static Text value;
    Text valuetext;

    // Start is called before the first frame update
    void Start()
    {
        value = GetComponent<Text>();
        // i = GameObject.Find("Slider2").GetComponent<Slider>().value;
        // string value = i.ToString("f1");
    }

    // Update is called once per frame
    void Update()
    {

    }
}
