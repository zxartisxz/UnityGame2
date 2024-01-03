using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


/// <summary>
/// Polar coordinates coverted to decart.
/// http://www.math.stonybrook.edu/~ndang/mat126-fall20/chap7.pdf
/// Have some different paterns of button movements
/// 
/// Octave help file:
/// E:\OneDrive\Unity\6_Game_jam_Artis\6GJ_AE\Looop_in_loop_graph.m
/// </summary>



public class MovingAnswers : MonoBehaviour
{
    [SerializeField]
    Transform rotationCenter;

    //[SerializeField]
    private float rotationMagnitude = 360f, angleSpeed = 1f, rotationRadius;

    private float posX, posY;//, angle2;
    public float angle;
    public static float speedDevider;

    private float a, b;
    //public static float angle3 =3;

    // Start is called before the first frame update
    void Start()
    {
        angle = angle * Mathf.PI / 180; // from degrees to radians
        speedDevider = 1;
    }

    // Update is called once per frame
    void Update()
    {

        switch (ButtonTextChanger.difficulity)
        {
            case 1:
                rotationRadius = 2 * Mathf.Cos(angle) + 0.3f;// Loop in a loop // my first sucsess!!
                posX = rotationCenter.position.x - 400 + Mathf.Cos(angle) * rotationRadius * rotationMagnitude / 1f;
                posY = rotationCenter.position.y + Mathf.Sin(angle) * rotationRadius * rotationMagnitude / 2f;
                transform.position = new Vector2(posX, posY);
                angle = angle + Time.deltaTime * angleSpeed / 2;
                break;
            case 2:
                rotationRadius = 3 * Mathf.Sin(3 * angle); //5 petal flower
                posX = rotationCenter.position.x + Mathf.Cos(angle) * rotationRadius * rotationMagnitude / 2 / 1.2f;
                posY = rotationCenter.position.y + Mathf.Sin(angle) * rotationRadius * rotationMagnitude / 4 / 1.2f;
                transform.position = new Vector2(posX, posY);
                angle = angle + Time.deltaTime * angleSpeed / 5;
                break;
            case 3:
                rotationRadius = 3 * Mathf.Sin(2 * angle); //4 petal flower
                posX = rotationCenter.position.x + Mathf.Cos(angle) * rotationRadius * rotationMagnitude / 2.5f;
                posY = rotationCenter.position.y + Mathf.Sin(angle) * rotationRadius * rotationMagnitude / 4.5f;
                transform.position = new Vector2(posX, posY);
                angle = angle + Time.deltaTime * angleSpeed / 2;
                break;
            case 4:

                a = 25;
                b = 10;
                rotationRadius = 1;//5 corner star
                posX = rotationCenter.position.x + (a * Mathf.Cos(angle) + b * Mathf.Cos((a - b) / b * angle)) * rotationRadius * rotationMagnitude / 2 / 14;
                posY = rotationCenter.position.y + (a * Mathf.Sin(angle) - b * Mathf.Sin((a - b) / b * angle)) * rotationRadius * rotationMagnitude / 4 / 14;
                transform.position = new Vector2(posX, posY);
                angle = angle + Time.deltaTime * angleSpeed / (1 / speedDevider);
                // http://www.math.stonybrook.edu/~ndang/mat126-fall20/chap7.pdf
                break;
            case 5:
                rotationRadius = 7 * Mathf.Sin(7 * angle); //7 petal flower
                posX = rotationCenter.position.x + Mathf.Cos(angle) * rotationRadius * rotationMagnitude / 2 / 3;
                posY = rotationCenter.position.y + Mathf.Sin(angle) * rotationRadius * rotationMagnitude / 4 / 3;
                transform.position = new Vector2(posX, posY);
                angle = angle + Time.deltaTime * angleSpeed / 10;
                break;
            case 6:
                a = 8;
                b = 3;
                rotationRadius = 1;//5 corner star
                posX = rotationCenter.position.x + (a * Mathf.Cos(angle) + b * Mathf.Cos((a - b) / b * angle)) * rotationRadius * rotationMagnitude / 2 / 6;
                posY = rotationCenter.position.y + (a * Mathf.Sin(angle) - b * Mathf.Sin((a - b) / b * angle)) * rotationRadius * rotationMagnitude / 4 / 6;
                transform.position = new Vector2(posX, posY);
                angle = angle + Time.deltaTime * angleSpeed / (1 / speedDevider);
                //// http://www.math.stonybrook.edu/~ndang/mat126-fall20/chap7.pdf

                //rotationRadius = 5 * Mathf.Sin(5 * angle); //5 petal flower
                //posX = rotationCenter.position.x + Mathf.Cos(angle) * rotationRadius * rotationMagnitude / 2 / 2f;
                //posY = rotationCenter.position.y + Mathf.Sin(angle) * rotationRadius * rotationMagnitude / 4 / 2f;
                //transform.position = new Vector2(posX, posY);
                //angle = angle + Time.deltaTime * angleSpeed / 7;
                break;
        }
        /* //Alternativa
        transform.RotateAround(target.transform.position, 
           new Vector3(0,0,-1), 20 * Time.deltaTime); Rote ap centra objektu

        transform.rotation = Quaternion.Euler(0, 0, 0); //negriezas ap savu asi
        */


        if (false)// not  working
        {
            //rotationRadius = 1; // 7 * Mathf.Sin(7 * angle);

            //posX = rotationCenter.position.x + Random.Range(-1, 1) * Mathf.Cos(angle) * rotationRadius * rotationMagnitude;
            //posY = rotationCenter.position.y + Random.Range(-1, 1) * Mathf.Sin(angle) * rotationRadius * rotationMagnitude / 2;
            //transform.position = new Vector2(posX, posY);
            //angle = angle + Time.deltaTime * angleSpeed / 10000;
        }

    }
}
