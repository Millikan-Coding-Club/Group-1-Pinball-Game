using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{   
    public Animator leftPaddleAnimator;
    public Animator rightPaddleAnimator;

    // Update is called once per frame
    void Update()
    {
        if ( Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.LeftArrow) ) {
            leftPaddleAnimator.ResetTrigger("Pressed");
            leftPaddleAnimator.SetTrigger("Pressed");
        }

        if ( Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.RightArrow) ) {
            rightPaddleAnimator.ResetTrigger("Pressed");
            rightPaddleAnimator.SetTrigger("Pressed");
        }
    }
}
