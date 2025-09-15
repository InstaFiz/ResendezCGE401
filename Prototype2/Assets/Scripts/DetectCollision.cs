/*
 * Jesse Resendez
 * Assignment 2
 * Allows objects to detect collision
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollision : MonoBehaviour
{
    private DisplayScore displayScoreScript;

	private void OnTriggerEnter(Collider other)
	{
        displayScoreScript.score++;
		Destroy(other.gameObject);
		Destroy(gameObject);
	}

    // Start is called before the first frame update
    private void Start()
    {
        displayScoreScript = GameObject.FindGameObjectWithTag("DisplayScoreText").GetComponent<DisplayScore>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
