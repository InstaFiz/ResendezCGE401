/*
 * Jesse Resendez
 * Assignment 2
 * You lose the game by falling off the road.
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLoseOnFall : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < -51 || transform.position.y > 80)
        {
            ScoreManager.gameOver = true;
        }
    }
}
