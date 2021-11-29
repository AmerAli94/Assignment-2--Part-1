// ===============================
// PROGRAM NAME: GAME Programming (T163)
// STUDENT ID : 101206769
// AUTHOR     : AMER ALI MOHAMMED
// CREATE DATE     : Nov 26, 2021
// PURPOSE     : GAME2014_F2021_ASSIGNMENT2_Part1
// SPECIAL NOTES:
// ===============================
// Change History:
// Added Audio manager for various sounds in game
//==================================
//==================================
// Change History:
// 
//==================================

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public static AudioManager instance; // singleton based audio manager

    //Sounds
    public AudioClip jump, landing, firing, damage, pickup , firemiss;

    public GameObject soundObject;

    void Awake()
    {
        instance = this;
    }

    public void PlaySound(string soundName)
    {
        switch(soundName)
        {
            case "jump":
                CreateSoundObject(jump);
                break;
            case "landing":
                CreateSoundObject(landing);
                break;
            case "enemyfire":
                CreateSoundObject(firing);
                break;
            case "playerhit":
                CreateSoundObject(damage);
                break;
            case "pickup":
                CreateSoundObject(pickup);
                break;
            case "firemiss":
                CreateSoundObject(firemiss);
                break;


        }
    }

    //using one function to instantiate the sound as an object and play it.

    public void CreateSoundObject(AudioClip clip)
    {
        //Instantiate sound object
        GameObject newObject = Instantiate(soundObject, transform);


        //Assign AudioClip 
        newObject.GetComponent<AudioSource>().clip = clip;

        newObject.GetComponent<AudioSource>().Play();

    }
}
