using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetBall : MonoBehaviour
{
    public Transform ball;

    public void OnCollisionEnter2D(Collision2D collision) 
    {
        ball.position = new Vector3( ball.position.x, 4.5f, ball.position.z);
    }
}