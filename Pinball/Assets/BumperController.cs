using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BumperController : MonoBehaviour
{ 
    public GameController gameController; 
    public void OnCollisionEnter2D(Collision2D collision) 
    {
        gameController.AddScore();
    }
}
