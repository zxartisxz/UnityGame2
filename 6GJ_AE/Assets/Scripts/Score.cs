using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Score : MonoBehaviour
{
    public Text score;
    public Text Importance;
    public static int inportance;
    
    // Start is called before the first frame update
    void Start()
    {
        score.text = "Score: 0";
        //score = GameObject.Find("Score");
        inportance = Random.Range(0, 2);


        if (inportance == 0)
        {
            Importance.text = "Letters";
        }
        else if (inportance == 1)
        {
            Importance.text = "Colors";
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (ButtonText.buttonPressedScore)
        {
            inportance = Random.Range(0, 2);

            if(inportance == 0)
            {
                Importance.text = "Letters";
            }
            else if (inportance == 1)
            {
                Importance.text = "Colors";
            }

            //scoreToAdd =  <color=green> Correct! </color>
            if (ButtonText.isCorrect2 == true)
            {
                // score.text = "Score: " + ButtonTextChanger.score +
                //"\n<color=lime> + " + ButtonTextChanger.scoreToAdd + "</color>";
                if (ButtonTextChanger.currentScene != "PlayScene_1")
                {
                    score.text = "Score: " + ButtonTextChanger.score +
                    "\n<color=lime> + " + ButtonTextChanger.scoreToAdd + "</color>";
                }
                else if (ButtonTextChanger.currentScene == "PlayScene_1")
                {
                    score.text = "Score: " + ButtonTextChanger.score +
                    "\n<color=lime> + " + ButtonTextChanger.scoreToAdd*5 + "</color>";
                }
                ButtonText.isCorrect2 = false;
            }
            else
            {
                score.text = "Score: " + ButtonTextChanger.score +
                "\n<color=red>  + 0</color>";
            }



            ButtonText.buttonPressedScore = false;
        }
        //else if (ButtonTextChanger.score >= Timer.winScore)
        //{
        //    Debug.Log("To win scene!");
        //    SceneManager.LoadScene("WinScene");
        //}

       
    }
}
