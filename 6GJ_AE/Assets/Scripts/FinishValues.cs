using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class FinishValues : MonoBehaviour
{
    public Text score;
    public Text TimeLeft;
    float timeRemaining;

    // Start is called before the first frame update
    void Start()
    {
        score.text = "Score: " + Timer.finishSkore;
        timeRemaining = Timer.finishTime;
        int seconds = (int)timeRemaining % 60;
        int minutes = (int)timeRemaining / 60;
        TimeLeft.text = "Time left: " + string.Format("{0,1:00}:{1,2:00}", minutes, seconds);
        //Debug.Log("FinisheValues script started.");
        //Debug.Log("score: " + Timer.finishSkore);
        //Debug.Log("TimeLeft: " + Timer.finishTime);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
