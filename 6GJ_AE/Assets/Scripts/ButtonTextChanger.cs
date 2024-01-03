using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ButtonTextChanger : MonoBehaviour
{
    public static GameObject taskImage, button0, button1, button2, button3, button4;
    public static string[] buttons = { "Button0", "Button1", "Button2", "Button3", "Button4" };
    public static string[] characters = {"0" ,"A", "B", "C", "D", "F", "G", "H", "I", "J", "K",
        "L", "M","N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z", "1",
        "2", "3", "4", "5", "6", "7", "8", "9","0","0"};//lenght = 35, characters[0] = 0;
    public static string TempLetter;
    public static string[] tempStringName = { "", "", "", "", "", "" },
        taskString = {"", "", "", "", "", "" };
    private int randomIndex, randomIndex2;
    public static int difficulity = 1;
    public static int score, scoreToAdd, correctBalance;
    public static string currentScene;

    public static bool addTime = false;

    // Start is called before the first frame update
    void Start()
    {
        currentScene = SceneManager.GetActiveScene().name;
        scoreToAdd = 1;
        correctBalance = 0;
        score = 0;

        taskImage = GameObject.Find("TaskText");
        button0 = GameObject.Find("BTxt0");
        button1 = GameObject.Find("BTxt1");
        button2 = GameObject.Find("BTxt2");
        button3 = GameObject.Find("BTxt3");
        button4 = GameObject.Find("BTxt4");

        //exampleString = taskImage.GetComponent<Text>().text;
        //Debug.Log("taskImage text: " + exampleString);
        //Debug.Log("character[0]: " + characters[0]);

        taskImage.GetComponent<Text>().text = "";

        button0.GetComponent<Text>().text = "";
        button1.GetComponent<Text>().text = "";
        button2.GetComponent<Text>().text = "";
        button3.GetComponent<Text>().text = "";
        button4.GetComponent<Text>().text = "";


        randomIndex = Random.Range(0, 37);
        //Debug.Log("character[randomIndex]: " + characters[randomIndex]);
        for (int i = 0; i < difficulity; i++)
        {
            taskImage.GetComponent<Text>().text += characters[randomIndex];
            randomIndex = Random.Range(0, 37);
            button0.GetComponent<Text>().text += characters[randomIndex];
            randomIndex = Random.Range(0, 37);
            button1.GetComponent<Text>().text += characters[randomIndex];
            randomIndex = Random.Range(0, 37);
            button2.GetComponent<Text>().text += characters[randomIndex];
            randomIndex = Random.Range(0, 37);
            button3.GetComponent<Text>().text += characters[randomIndex];
            randomIndex = Random.Range(0, 37);
            button4.GetComponent<Text>().text += characters[randomIndex];
        }
        button1.GetComponent<Text>().text = taskImage.GetComponent<Text>().text;

        randomIndex2 = Random.Range(0, 5);
        switch (randomIndex2)
        {
            case 0:
                button0.GetComponent<Text>().text = taskImage.GetComponent<Text>().text;
                break;
            case 1:
                button1.GetComponent<Text>().text = taskImage.GetComponent<Text>().text;
                break;
            case 2:
                button2.GetComponent<Text>().text = taskImage.GetComponent<Text>().text;
                break;
            case 3:
                button3.GetComponent<Text>().text = taskImage.GetComponent<Text>().text;
                break;
            case 4:
                button4.GetComponent<Text>().text = taskImage.GetComponent<Text>().text;
                break;
            case 5:
                button4.GetComponent<Text>().text = taskImage.GetComponent<Text>().text;
                break;


        }
    }
    // Update is called once per frame
    void Update()
    {
        if (ButtonText.buttonPressed) //need to change all button colors
        {
            if (ButtonText.isCorrect == true)//
            {
                correctBalance += 1;
                if (currentScene != "PlayScene_1")
                {
                    score += scoreToAdd;
                    MovingAnswers.speedDevider += 0.02f;
                }
                else if (currentScene == "PlayScene_1")
                {
                    score += scoreToAdd * 5;
                }

                //Debug.Log("scored: " + score);
                addTime = true;
                ButtonText.isCorrect2 = true;
                ButtonText.isCorrect = false;
            }
            else if (ButtonText.isCorrect == false && correctBalance > 0)
            {
                correctBalance -= 2;
                MovingAnswers.speedDevider -= 0.05f;
            }

            taskImage.GetComponent<Text>().text = "";

            button0.GetComponent<Text>().text = "";
            button1.GetComponent<Text>().text = "";
            button2.GetComponent<Text>().text = "";
            button3.GetComponent<Text>().text = "";
            button4.GetComponent<Text>().text = "";

            if(correctBalance < 3) { difficulity = 1; }
            else if(correctBalance > 2 && correctBalance < 5) { difficulity = 2; }
            else if(correctBalance > 4 && correctBalance < 8) { difficulity = 3; }
            else if(correctBalance > 7 && correctBalance < 13) { difficulity = 4; }
            else if(correctBalance > 12 && correctBalance < 20) { difficulity = 5; }
            else if(correctBalance > 24 ) { difficulity = 6; }


            if (difficulity < 4) //Goood for now here
            {
                randomIndex = Random.Range(0, 37);
                //Debug.Log("character[randomIndex]: " + characters[randomIndex]);
                for (int i = 0; i < difficulity; i++)
                {
                    taskImage.GetComponent<Text>().text += characters[randomIndex];
                    randomIndex = Random.Range(0, 37);
                    button0.GetComponent<Text>().text += characters[randomIndex];
                    randomIndex = Random.Range(0, 37);
                    button1.GetComponent<Text>().text += characters[randomIndex];
                    randomIndex = Random.Range(0, 37);
                    button2.GetComponent<Text>().text += characters[randomIndex];
                    randomIndex = Random.Range(0, 37);
                    button3.GetComponent<Text>().text += characters[randomIndex];
                    randomIndex = Random.Range(0, 37);
                    button4.GetComponent<Text>().text += characters[randomIndex];
                }
            }
            else if (difficulity > 3) // need to solve
            {
                //Debug.Log("difficulity > 2");
                for (int i = 0; i < difficulity; i++)
                {
                    
                    randomIndex = Random.Range(0, 37);
                    //Debug.Log("Random.Range(0, 37); started");
                    taskString[i] = characters[randomIndex];
                    //Debug.Log("taskString[i]:" + taskString[i]);
                    //Debug.Log("characters[randomIndex]" + characters[randomIndex]);
                    tempStringName[i] = taskString[i]; 
                    taskImage.GetComponent<Text>().text += characters[randomIndex];
                }


                //button0.GetComponent<Text>().text = taskImage.GetComponent<Text>().text;
                //tempStringName = taskImage.GetComponent<Text>().text;
                //button1.GetComponent<Text>().text = taskImage.GetComponent<Text>().text;
                //button2.GetComponent<Text>().text = taskImage.GetComponent<Text>().text;
                //button3.GetComponent<Text>().text = taskImage.GetComponent<Text>().text;
                //button4.GetComponent<Text>().text = taskImage.GetComponent<Text>().text;

                /************************mixing values*********************************/
                // Button0
                for (int i = 0; i < taskImage.GetComponent<Text>().text.Length; i++)
                {//mixing values

                    TempLetter = tempStringName[i];
                    randomIndex = Random.Range(i, tempStringName.Length);
                    tempStringName[i] = tempStringName[randomIndex];
                    tempStringName[randomIndex] = TempLetter;

                }
                
                for (int i = 0; i < difficulity; i++)
                {
                    button0.GetComponent<Text>().text += tempStringName[i];
                }
                /********************************************************************/
                //Button1

                for (int i = 0; i < taskImage.GetComponent<Text>().text.Length; i++)
                {//mixing values

                    TempLetter = tempStringName[i];
                    randomIndex = Random.Range(i, tempStringName.Length);
                    tempStringName[i] = tempStringName[randomIndex];
                    tempStringName[randomIndex] = TempLetter;

                }
                
                for (int i = 0; i < difficulity; i++)
                {
                    button1.GetComponent<Text>().text += tempStringName[i];
                }
                /********************************************************************/
                //Button2
                for (int i = 0; i < taskImage.GetComponent<Text>().text.Length; i++)
                {//mixing values

                    TempLetter = tempStringName[i];
                    randomIndex = Random.Range(i, tempStringName.Length);
                    tempStringName[i] = tempStringName[randomIndex];
                    tempStringName[randomIndex] = TempLetter;

                }

                for (int i = 0; i < difficulity; i++)
                {
                    button2.GetComponent<Text>().text += tempStringName[i];
                }
                /********************************************************************/
                //Button3
                for (int i = 0; i < taskImage.GetComponent<Text>().text.Length; i++)
                {//mixing values

                    TempLetter = tempStringName[i];
                    randomIndex = Random.Range(i, tempStringName.Length);
                    tempStringName[i] = tempStringName[randomIndex];
                    tempStringName[randomIndex] = TempLetter;

                }

                for (int i = 0; i < difficulity; i++)
                {
                    button3.GetComponent<Text>().text += tempStringName[i];
                }
                /********************************************************************/
                //Button4
                for (int i = 0; i < taskImage.GetComponent<Text>().text.Length; i++)
                {//mixing values

                    TempLetter = tempStringName[i];
                    randomIndex = Random.Range(i, tempStringName.Length);
                    tempStringName[i] = tempStringName[randomIndex];
                    tempStringName[randomIndex] = TempLetter;

                }

                for (int i = 0; i < difficulity; i++)
                {
                    button4.GetComponent<Text>().text += tempStringName[i];
                }
                /********************************************************************/
                /*****************mixing values End**********************************/


            }
            randomIndex2 = Random.Range(0, 5);
            switch (randomIndex2)
            {
                case 0:
                    button0.GetComponent<Text>().text = taskImage.GetComponent<Text>().text;
                    break;
                case 1:
                    button1.GetComponent<Text>().text = taskImage.GetComponent<Text>().text;
                    break;
                case 2:
                    button2.GetComponent<Text>().text = taskImage.GetComponent<Text>().text;
                    break;
                case 3:
                    button3.GetComponent<Text>().text = taskImage.GetComponent<Text>().text;
                    break;
                case 4:
                    button4.GetComponent<Text>().text = taskImage.GetComponent<Text>().text;
                    break;
                case 5:
                    button4.GetComponent<Text>().text = taskImage.GetComponent<Text>().text;
                    break;
            }
            if (correctBalance >= 0)
            {
                scoreToAdd = correctBalance;
            }
            //scoreToAdd = correctBalance;
            ButtonText.buttonPressed = false;





        }
    }
}
