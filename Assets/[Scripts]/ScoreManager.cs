// PROGRAM NAME: GAME Programming (T163)
// STUDENT ID : 101206769
// AUTHOR     : AMER ALI MOHAMMED
// CREATE DATE     : Nov 26, 2021
// PURPOSE     : GAME2014_F2021_ASSIGNMENT2_Part1
// SPECIAL NOTES:
// ===============================
// Change History:
// Added score manager 
//==================================
//==================================
// Change History:
// 
//==================================


using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;
    public Text starsText;
    public Text remainingStarsText;

    int stars = 0;
    [Range(1,6)]
    public int totalStars = 6;

    private void Awake()
    {
        instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        starsText.text = "- " + stars.ToString();
        remainingStarsText.text = " " + totalStars.ToString();
    }

    public void AddPoint() // will be called by pickup script
    {
        stars += 1;
        totalStars -= 1;
        starsText.text = "- " + stars.ToString();
        remainingStarsText.text = " " + totalStars.ToString();
    }

    public void Update()
    {
        if(totalStars <=  0)
        {
            Debug.Log("You Won");
        }
        //storing score
        PlayerPrefs.SetInt("Collected Stars", stars);

    }

}
