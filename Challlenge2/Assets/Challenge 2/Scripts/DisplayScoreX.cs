using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayScoreX : MonoBehaviour
{
    public Text textbox;
    public int score = 0;
    public int health = 5;
    public static bool gameOver;
    public static bool won;

    // Start is called before the first frame update
    void Start()
    {
        gameOver = false;
        won = false;
        textbox = GetComponent<Text>();
        textbox.text = "Score: 0";
    }

    // Update is called once per frame
    void Update()
    {
        if (!gameOver)
        {
            textbox.text = "Score: " + score + "\nHealth: " + health;
        }

        if (score >= 5)
        {
            won = true;
            gameOver = true;
        }

        if (health <= 0)
        {
            won = false;
            gameOver = true;
        }

        if (gameOver)
        {
            if (won)
            {
                textbox.text = "You win!\nPress R to Try Again!";
            }
            else
            {
                textbox.text = "You lose!\nPress R to Try Again!";
            }

            if (Input.GetKeyDown(KeyCode.R))
            {
                won = false;
                gameOver = false;
                score = 0;
                health = 5;
            }
        }
    }
}