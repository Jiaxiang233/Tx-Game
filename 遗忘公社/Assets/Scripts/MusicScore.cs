using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicScore : MonoBehaviour
{
    public static MusicScore Instance;
    public RectTransform tf;
    public float shift=0;
    public float moveDistance;
    
    // Start is called before the first frame update
    void Start()
    {
        tf = GetComponent<RectTransform>();
    }

    private void Awake()
    {
        Instance = this;
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void test(float distance)
    {
        moveDistance = distance;
        string values = distance.ToString("f1");
        justtest.value.text = values;
    }

    public void ScoreMove(int code)//向左移动乐谱
    {
        if (code == 1)
        {
             transform.Translate(-moveDistance, 0, 0);
             shift += moveDistance;
        }
    }
  


    public void ScoreRes()//重置位置
    {
         transform.Translate(shift, 0, 0);
         shift = 0;

    }
   

}
