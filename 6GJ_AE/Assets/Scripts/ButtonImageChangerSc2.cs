using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ButtonImageChangerSc2 : MonoBehaviour
{
    //public static Sprite[] QSprites;

    //private Color TaskImageColor;

    public static int[] quizNumber = { 0, 1, 2, 3, 4 };
    public static int[] quizNumberStart = { 0, 0, 0, 0, 0 };

    private int randomIndex;

    public static bool addTime = false;
    public static string[] buttons = { "Button0", "Button1", "Button2", "Button3", "Button4" };


    public static int score, scoreToAdd, correctBalance;

    public static GameObject taskImage, button0, button1, button2, button3, button4;

    public static float r, g, b, r0, g0, b0, minColor = 20, maxColor = 127, maxTaskColor = 127, minOffset, maxOffset;
    public static float minColor2 = 85;

    public static string currentScene;
    // Start is called before the first frame update
    void Start()
    {
        currentScene = SceneManager.GetActiveScene().name;
        //Debug.Log("Current scene: " + currentScene);

        //scoreToAdd = 1;
        //correctBalance = 0;
        //score = 0;

        //Color newColor = new Color(0.3f, 0.4f, 0.6f, 0.3f);
        taskImage = GameObject.Find("TaskImage");
        button0 = GameObject.Find("Button0");
        button1 = GameObject.Find("Button1");
        button2 = GameObject.Find("Button2");
        button3 = GameObject.Find("Button3");
        button4 = GameObject.Find("Button4");

        Color newTaskImageColorColor = taskImage.GetComponent<Image>().color;
        Color button0_Color = button0.GetComponent<Image>().color;
        Color button1_Color = button1.GetComponent<Image>().color;
        Color button2_Color = button2.GetComponent<Image>().color;
        Color button3_Color = button3.GetComponent<Image>().color;
        Color button4_Color = button4.GetComponent<Image>().color;

        r = Random.Range(minColor2, 255);
        g = Random.Range(minColor2, 255);
        b = Random.Range(minColor2, 255);
        //Debug.Log("r: " + r / 255 + ", g: " + g / 255 + ", b: " + b / 255);
        taskImage.gameObject.GetComponent<Image>().color = new Color(r / 255, g / 255, b / 255);
        r = Random.Range(minColor2, 255);
        g = Random.Range(minColor2, 255);
        b = Random.Range(minColor2, 255);
        button0.gameObject.GetComponent<Image>().color = new Color(r / 255, g / 255, b / 255);
       
        r = Random.Range(minColor2, 255);
        g = Random.Range(minColor2, 255);
        b = Random.Range(minColor2, 255);
        button1.gameObject.GetComponent<Image>().color = new Color(r / 255, g / 255, b / 255);

        r = Random.Range(minColor2, 255);
        g = Random.Range(minColor2, 255);
        b = Random.Range(minColor2, 255);
        button2.gameObject.GetComponent<Image>().color = new Color(r / 255, g / 255, b / 255);

        r = Random.Range(minColor2, 255);
        g = Random.Range(minColor2, 255);
        b = Random.Range(minColor2, 255);
        button3.gameObject.GetComponent<Image>().color = new Color(r / 255, g / 255, b / 255);

        r = Random.Range(minColor2, 255);
        g = Random.Range(minColor2, 255);
        b = Random.Range(minColor2, 255);
        button4.gameObject.GetComponent<Image>().color = new Color(r / 255, g / 255, b / 255);

        //Debug.Log("Task image color is " + taskImage.gameObject.GetComponent<Image>().color);
        randomIndex = Random.Range(0, 5);
        switch (randomIndex)
        {
            case 0:
                button0.gameObject.GetComponent<Image>().color = taskImage.gameObject.GetComponent<Image>().color;
                break;
            case 1:
                button1.gameObject.GetComponent<Image>().color = taskImage.gameObject.GetComponent<Image>().color;
                break;
            case 2:
                button2.gameObject.GetComponent<Image>().color = taskImage.gameObject.GetComponent<Image>().color;
                break;
            case 3:
                button3.gameObject.GetComponent<Image>().color = taskImage.gameObject.GetComponent<Image>().color;
                break;
            case 4:
                button4.gameObject.GetComponent<Image>().color = taskImage.gameObject.GetComponent<Image>().color;
                break;
            case 5:
                button4.gameObject.GetComponent<Image>().color = taskImage.gameObject.GetComponent<Image>().color;
                break;
        }


      

    }

    // Update is called once per frame
    void Update()
    {
        if (ButtonText.buttonPressedColor) //need to change all button colors
        {
            
            maxColor = 255;


            r = Random.Range(minColor2, maxColor);
            g = Random.Range(minColor2, maxColor);
            b = Random.Range(minColor2, maxColor);

            //Debug.Log("r: " + r/255 + ", g: " + g/255 + ", b: " + b/255);
            taskImage.gameObject.GetComponent<Image>().color = new Color(r / 255, g / 255, b / 255);

            r0 =  Random.Range(minColor2, maxColor );
            g0 =  Random.Range(minColor2, maxColor );
            b0 =  Random.Range(minColor2, maxColor );
            button0.gameObject.GetComponent<Image>().color = new Color(r0 / 255, g0 / 255, b0 / 255);

            //if( r0 > 254 || g0 > 254 || b0 > 254) { Debug.Log("r0: " +r0+ ",g0: " + g0+ ",b0: " + b0 ); }

            r0 =  Random.Range(minColor2, maxColor );
            g0 =  Random.Range(minColor2, maxColor );
            b0 =  Random.Range(minColor2, maxColor );
            button1.gameObject.GetComponent<Image>().color = new Color(r0 / 255, g0 / 255, b0 / 255);

            //if (r0 > 254 || g0 > 254 || b0 > 254) { Debug.Log("r0: " + r0 + ",g0: " + g0 + ",b0: " + b0); }

            r0 =  Random.Range(minColor2, maxColor );
            g0 =  Random.Range(minColor2, maxColor );
            b0 =  Random.Range(minColor2, maxColor );
            button2.gameObject.GetComponent<Image>().color = new Color(r0 / 255, g0 / 255, b0 / 255);

            //if (r0 > 254 || g0 > 254 || b0 > 254) { Debug.Log("r0: " + r0 + ",g0: " + g0 + ",b0: " + b0); }

            r0 =  Random.Range(minColor2, maxColor );
            g0 =  Random.Range(minColor2, maxColor );
            b0 =  Random.Range(minColor2, maxColor );
            button3.gameObject.GetComponent<Image>().color = new Color(r0 / 255, g0 / 255, b0 / 255);

            //if (r0 > 254 || g0 > 254 || b0 > 254) { Debug.Log("r0: " + r0 + ",g0: " + g0 + ",b0: " + b0); }

            r0 =  Random.Range(minColor2, maxColor );
            g0 =  Random.Range(minColor2, maxColor );
            b0 =  Random.Range(minColor2, maxColor );
            button4.gameObject.GetComponent<Image>().color = new Color(r0 / 255, g0 / 255, b0 / 255);

            //if (r0 > 254 || g0 > 254 || b0 > 254) { Debug.Log("r0: " + r0 + ",g0: " + g0 + ",b0: " + b0); }


            randomIndex = Random.Range(0, 5);
            //Debug.Log(" Random.Range(0, 5) = " + randomIndex);
            switch (randomIndex)
            {
                case 0:
                    button0.gameObject.GetComponent<Image>().color = taskImage.gameObject.GetComponent<Image>().color;
                    break;
                case 1:
                    button1.gameObject.GetComponent<Image>().color = taskImage.gameObject.GetComponent<Image>().color;
                    break;
                case 2:
                    button2.gameObject.GetComponent<Image>().color = taskImage.gameObject.GetComponent<Image>().color;
                    break;
                case 3:
                    button3.gameObject.GetComponent<Image>().color = taskImage.gameObject.GetComponent<Image>().color;
                    break;
                case 4:
                    button4.gameObject.GetComponent<Image>().color = taskImage.gameObject.GetComponent<Image>().color;
                    break;
                case 5:
                    button4.gameObject.GetComponent<Image>().color = taskImage.gameObject.GetComponent<Image>().color;
                    break;
            }
            if (correctBalance >= 0)
            {
                scoreToAdd = correctBalance;
            }
            //scoreToAdd = correctBalance;
            ButtonText.buttonPressedColor = false; ;
        }
    }

}
