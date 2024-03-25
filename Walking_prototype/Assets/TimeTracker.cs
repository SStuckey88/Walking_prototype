using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class TimeTracker : MonoBehaviour
{
    public TextMeshProUGUI TimeText;
    public float Timer;

    
    // Start is called before the first frame update
    void Start()
    {
        TimeText.text = "";
    }

    // Update is called once per frame
    void Update()
    {
        Timer += Time.deltaTime;
        int minutes = Mathf.FloorToInt(Timer / 60F);
        int seconds = Mathf.FloorToInt(Timer % 60F);
        int milliseconds = Mathf.FloorToInt((Timer * 100F) % 100F);
        TimeText.text = "Timer: "+minutes.ToString("00") + ":" + seconds.ToString("00");
    }

}
