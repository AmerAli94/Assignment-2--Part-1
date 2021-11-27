// ===============================
// PROGRAM NAME: GAME Programming (T163)
// STUDENT ID : 101206769
// AUTHOR     : AMER ALI MOHAMMED
// CREATE DATE     : Nov 26, 2021
// PURPOSE     : GAME2014_F2021_ASSIGNMENT2_Part1
// SPECIAL NOTES:
// ===============================
// Change History:
// Added for Main Menu UI. 
//==================================
//==================================
// Change History:
// 
//==================================


using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class PlayButton : MonoBehaviour
{

    public Animator animation;
    private float WaitforMenuLoad = 1.0f;


    // Start is called before the first frame update
    void Start()
    {
        animation.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnStartPressed()
    {
        animation.enabled = true;
        animation.GetComponent<Animator>().Play("StartButton");
        StartCoroutine(LoadMenu());
        Debug.Log("Start Pressed");
    }

    IEnumerator LoadMenu()
    {
        yield return new WaitForSeconds(WaitforMenuLoad);
        SceneManager.LoadScene("Main");
    }
}
