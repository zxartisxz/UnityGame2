using UnityEngine;

public class Exit : MonoBehaviour
{
    public void exitGame()
    {
        Debug.Log("Exit is pressed!");
        Application.Quit();
    }
}
