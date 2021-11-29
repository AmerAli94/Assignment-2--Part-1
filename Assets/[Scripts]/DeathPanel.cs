using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class DeathPanel : MonoBehaviour
{
 

    public void Start()
    {
    }

    public void OnReplayPressed()
    {
        SceneManager.LoadScene("Main");
    }

    public void OnMenuPresses()
    {
        SceneManager.LoadScene("Menu");
    }

    public void OnQuitPressed()
    {
        Application.Quit();
    }
}
