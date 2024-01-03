using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour
{
    public void LoadScene(string sceneName)
    {
        Debug.Log("You loaded: " + sceneName + " scene");
        SceneManager.LoadScene(sceneName);
    }
}
