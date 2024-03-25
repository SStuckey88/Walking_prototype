using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class ScoreTracker : MonoBehaviour
{
    // Start is called before the first frame update
    public TextMeshProUGUI ScoreText;
    public int score;

    public TextMeshProUGUI TimeText;
    public float Timer;
    private int once=1;


    void Start()
    {
        score = 0;
        ScoreText.text = "Score: " + score;
        TimeText.text = "";

    }

    // Update is called once per frame
    void Update()
    {
        Timer += Time.deltaTime;
        int minutes = Mathf.FloorToInt(Timer / 60F);
        int seconds = Mathf.FloorToInt(Timer % 60F);
        
        int milliseconds = Mathf.FloorToInt((Timer * 100F) % 100F);
        TimeText.text = "Timer: " + minutes.ToString("00") + ":" + seconds.ToString("00");
        ScoreText.text = "Score: " + score;
        if (seconds % 2 == 0 && once == 0 && seconds != 0)
        {
            once++;
            score += 5;

        }
        if (seconds % 2 != 0 && once == 1 && seconds != 0)
        {
            once--;
            score += 5;

        }

    }
}
