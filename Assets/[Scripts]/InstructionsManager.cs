using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstructionsManager : MonoBehaviour
{
    //
    public Animator instructionsBoxAnimator;
    public Animator animator;

    private float waitForAnimBool = 2.0f;


    // Start is called before the first frame update
    void Start()
    {
       //animator = GetComponent<Animator>();
       // instructionsBoxAnimator = GetComponent<Animator>();
        //
        instructionsBoxAnimator.SetBool("IsOpenActive", false);
        animator.SetBool("IsActive", false);
        Debug.Log(instructionsBoxAnimator);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnInstructionsButtonPressed()
    {
        //
        instructionsBoxAnimator.SetBool("IsOpenActive", true);
        animator.SetBool("IsActive", true);
        StartCoroutine(ChangeAnimatorBool());
    }

    IEnumerator ChangeAnimatorBool()
    {
        yield return new WaitForSeconds(waitForAnimBool);
        animator.SetBool("IsActive", false);
    }






}
