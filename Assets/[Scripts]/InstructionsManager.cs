// ===============================
// PROGRAM NAME: GAME Programming (T163)
// STUDENT ID : 101206769
// AUTHOR     : AMER ALI MOHAMMED
// CREATE DATE     : Nov 26, 2021
// PURPOSE     : GAME2014_F2021_ASSIGNMENT2_Part1
// SPECIAL NOTES:
// ===============================
// Change History:
// Added slidable Instructions Screen as part of UI
//==================================
//==================================
// Change History:
// 
//==================================

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstructionsManager : MonoBehaviour
{
    
    public Animator instructionsBoxAnimator;
    public Animator animator;
    public GameObject firstInstructionBox;
    public GameObject secondInstructionBox;

    private float waitForAnimBool = 2.0f;


    // Start is called before the first frame update
    void Start()
    {
        //Using bools as parameters to activate the animations
        instructionsBoxAnimator.SetBool("IsOpenActive", false);
        animator.SetBool("IsActive", false);
        Debug.Log(instructionsBoxAnimator);
    }


    public void OnInstructionsButtonPressed()
    {
        
        instructionsBoxAnimator.SetBool("IsOpenActive", true);
        instructionsBoxAnimator.SetBool("IsCloseActive", false);
        animator.SetBool("IsActive", true);
        StartCoroutine(ChangeAnimatorBool());
    }

    public void OnFirstInstructionsCloseButtonPress()
    {
        //using set active for gameobjects to hide & show Instructions screens/panels
        firstInstructionBox.SetActive(false);
        secondInstructionBox.SetActive(true);
    }

    public void OnPrevButtonPres()
    {
        secondInstructionBox.SetActive(false);
        firstInstructionBox.SetActive(true);
    }

    public void OnInstructionBoxCancelPress()
    {
        instructionsBoxAnimator.SetBool("IsOpenActive", false);
        instructionsBoxAnimator.SetBool("IsCloseActive", true);
    }

    //using coroutines to deactvate the bools for reuse or button represses
    IEnumerator ChangeAnimatorBool()
    {
        yield return new WaitForSeconds(waitForAnimBool);
        animator.SetBool("IsActive", false);
    }






}
