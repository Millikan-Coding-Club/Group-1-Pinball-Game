using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{   
    public Animator leftPaddleAnimator;
    public Animator rightPaddleAnimator;
    private Text scoreText;

    private int score = 0;
    // Update is called once per frame
    public void Update()
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
    public void AddScore()
    {
        score += 10;
        scoreText.text = "SCORE: " + score;
    }
}
