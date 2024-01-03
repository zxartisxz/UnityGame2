using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    public Text TimeLeft;
    public Text gameProgress;
  


    public static int winScore = 30, finishSkore = 0;

    public static float timeRemaining, addTimeFloat = 3.5039f, addTimePlaceHold, finishTime;
    int seconds, minutes;
    bool pausePressed = false;

    // Start is called before the first frame update
    void Start()
    {
        

        timeRemaining = 16.039f;

        //if (ButtonTextChanger.currentScene == "PlayScene_1")
        //{
        //    timeRemaining = 46f;
        //    addTimeFloat = 5.0f;
        //}
        addTimePlaceHold = 0;

        gameProgress.text = "Game progress:\n" +
                ButtonTextChanger.score + "/" + winScore + "(" +
                  ButtonTextChanger.score / winScore + "%)";
    }

    // Update is called once per frame
    void Update()
    {

        int percentCopleted = (int)((float)ButtonTextChanger.correctBalance / (float)winScore* 100);
        if (ButtonTextChanger.currentScene != "PlayScene_1")
        {
            gameProgress.text = "Game progress:\n" +
                  ButtonTextChanger.correctBalance + "/" + winScore + "(" +
                    percentCopleted + "%)";
        }
           
        if (ButtonTextChanger.currentScene == "PlayScene_1")
        {
            gameProgress.text = "Challange progress:\n" +
              ButtonTextChanger.correctBalance + "/" + winScore + "(" +
                percentCopleted + "%)";
        }
        

            if (timeRemaining > 0 && !pausePressed)
        {
            timeRemaining -= Time.deltaTime;
            seconds = (int)timeRemaining % 60;
            minutes = (int)timeRemaining / 60;
            TimeLeft.text = "Time: " + string.Format("{0,1:00}:{1,2:00}", minutes, seconds) +
                "\n<color=lime>+" + addTimePlaceHold + " seconds!</color>";
           
            //Debug.Log("Time remaining: " + timeRemaining);
        }

        if (ButtonTextChanger.addTime)
        {
            //b = System.Math.Round(a, 2);
            //<color=green> Correct! </color>
            //timeRemaining += addTimeFloat //System.Math.Round(addTimeFloat,1);
            timeRemaining += (float)System.Math.Round(addTimeFloat, 1);
            addTimePlaceHold = (float)System.Math.Round(addTimeFloat, 1);
            ButtonTextChanger.addTime = false;
            /*TimeLeft.text = "Time: " + string.Format("{0,1:00}:{1,2:00}", minutes, seconds) +
               "\n+ <color=green>" + addTimeFloat +"</color>";*/
        }


        else if (pausePressed)
        {
            TimeLeft.text = "Time: " + string.Format("{0,1:00}:{1,2:00}", minutes, seconds) +
                 " Paused!";
            timeRemaining += Time.deltaTime;
            timeRemaining -= Time.deltaTime;
        }
        //****************Lose********************
        else if(timeRemaining < 0)
        {
            finishSkore = ButtonTextChanger.score;
            finishTime = timeRemaining;
            SceneManager.LoadScene("LoseScene");
        }
        //****************Win*********************
        else if ( ButtonTextChanger.correctBalance > winScore)// && ButtonTextChanger.currentScene == "PlayScene")
        {
            finishSkore = ButtonTextChanger.score;
            finishTime = timeRemaining;
            Debug.Log("To win scene!");
            SceneManager.LoadScene("WinScene");
        }
        //else if (ButtonTextChanger.correctBalance > winScore && ButtonTextChanger.currentScene != "PlayScene_1")
        //{
        //    finishSkore = ButtonTextChanger.score;
        //    finishTime = timeRemaining;
        //    Debug.Log("To Playscene_1 !");
        //    SceneManager.LoadScene("LevelSeperateScene");
        //}
    }
    public void PressPause()
    {
        pausePressed = !pausePressed;
    }
}
