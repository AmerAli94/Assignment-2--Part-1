using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstructionsCancelButton : MonoBehaviour
{
    public Animator animator;
    public Animator instructionBoxAnimator;

    private float waitForCanelBoxAnimEnd = 2.0f;
    // Start is called before the first frame update
    void Start()
    {
        instructionBoxAnimator.GetComponent<Animator>();
        instructionBoxAnimator.SetBool("IsCloseActive", false);

    }

    // Update is called once per frame
    void Update()
    {
    }

    public void OnInstructionBoxCancelPress()
    {
        animator.SetBool("IsActive", true); //animate instructions box
        StartCoroutine(CloseInstructionBox());
    }

    IEnumerator CloseInstructionBox()
    {
        yield return new WaitForSeconds(waitForCanelBoxAnimEnd);
        instructionBoxAnimator.SetBool("IsCloseActive", true);
    }
}
