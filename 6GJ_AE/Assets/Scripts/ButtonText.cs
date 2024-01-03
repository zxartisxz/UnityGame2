using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ButtonText : MonoBehaviour
{
    public static bool buttonPressed = false;
    public static bool buttonPressedColor = false;
    public static bool buttonPressedScore = false;

    public static GameObject pressedButtonObject;

    public static bool isCorrect = false, isCorrect2 = false;

    public void SetButtonText()
    {
        //Debug.Log("Button is pressed " + this.transform.GetChild(0).gameObject.GetComponent<Text>().text);
        //Debug.Log("Type of color: " + this.gameObject.GetComponent<Image>().color.GetType());

        if (Score.inportance == 0) //Letters
        {
            if (this.transform.GetChild(0).gameObject.GetComponent<Text>().text == ButtonTextChanger.taskImage.gameObject.GetComponent<Text>().text)
            {
                isCorrect = true;
                //Debug.Log("Correct");
            }
            //else if (this.gameObject.GetComponent<Image>().color != ButtonImageChangerSc2.taskImage.gameObject.GetComponent<Image>().color)
            else if (this.transform.GetChild(0).gameObject.GetComponent<Text>().text != ButtonTextChanger.taskImage.gameObject.GetComponent<Text>().text)
            {
                isCorrect = false;
                //Debug.Log("Wrong, becase button color is " + this.gameObject.GetComponent<Image>().color +
                //    "but task color is " + ButtonImageChangerSc2.taskImage.gameObject.GetComponent<Image>().color);
            }
            else
            {
                Debug.Log("Something with colors gone wrong");
            }
        }
        else if(Score.inportance == 1) //Color
        {
            //Debug.Log("this.gameObject.GetComponent<Image>().color:" + this.gameObject.GetComponent<Image>().color);
            //Debug.Log("ButtonImageChangerSc2.taskImage.gameObject.GetComponent<Image>().color:" +
                //ButtonImageChangerSc2.taskImage.gameObject.GetComponent<Image>().color);

            if (this.gameObject.GetComponent<Image>().color == ButtonImageChangerSc2.taskImage.gameObject.GetComponent<Image>().color)
            //if (this.transform.GetChild(0).gameObject.GetComponent<Text>().text == ButtonTextChanger.taskImage.gameObject.GetComponent<Text>().text)
            {
                isCorrect = true;
                //Debug.Log("Correct");
            }
            else if (this.gameObject.GetComponent<Image>().color != ButtonImageChangerSc2.taskImage.gameObject.GetComponent<Image>().color)
            //else if (this.transform.GetChild(0).gameObject.GetComponent<Text>().text != ButtonTextChanger.taskImage.gameObject.GetComponent<Text>().text)
            {
                isCorrect = false;
                //Debug.Log("Wrong, becase button color is " + this.gameObject.GetComponent<Image>().color +
                //    "but task color is " + ButtonImageChangerSc2.taskImage.gameObject.GetComponent<Image>().color);
            }
            else
            {
                Debug.Log("Something with colors gone wrong");
            }
        }
        else if (Score.inportance == 3)
        {
            Debug.Log("Something with colors gone wrong! Score.inportance = " + Score.inportance);
        }





            pressedButtonObject = this.gameObject;
        buttonPressed = true;
        buttonPressedScore = true;
        buttonPressedColor = true;


    }


}
