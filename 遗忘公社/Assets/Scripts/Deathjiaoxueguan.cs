using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Deathjiaoxueguan : MonoBehaviour
{
    public Vector3 i;
    float lasttime;
    public GameObject text;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time - lasttime > 1.5f)
        {
            text.SetActive(false);
        }
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            DestroyImmediate(other.gameObject);
            GameObject.Find("Player").GetComponent<MelodyCheck>().currentMelodyList.Clear();
            lasttime = Time.time;
            text.SetActive(true);
            other.gameObject.transform.position = i;
        }
    }
}
