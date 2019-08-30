using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerManager : MonoBehaviour
{
    public Text timeText;
    private float time;
    public GameObject gOver;

    private void Update()
    {
        if(!gOver.activeSelf)
            time += Time.deltaTime;
        timeText.text = string.Format("TIME : {0:N2}", time);
    }
}
