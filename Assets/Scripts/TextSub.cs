using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextSub : MonoBehaviour
{
    public GameObject panel;
    public Text title;
    public string[] sub;
    public float timer;
    public float timerDown;
    public int i;
    public bool enter;

    public void Start()
    {
        timerDown = timer;
        panel.SetActive(false);
    }

    public void Update()
    {
        enter = true;
        if (i == 4)
        {
            panel.SetActive(false);
        }
        else
        {
            title.text = ""+sub[i]+"";
        }

        if (enter == true)
        {
            if (timerDown > 0)
            {
                timerDown -= Time.deltaTime;
                print(timerDown);
            }
            if (timerDown < 0)
            {
                timerDown = 0;
            }
            if (timerDown == 0)
            {
                timerDown = timer;
                i++;
            }
        }
    }
}
