using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static GlobalVariables;

public class GameManager : MonoBehaviour
{
    // Update is called once per frame
    void FixedUpdate()
    {
        if (lives == 0 || points1+points2 == 330)
        {
            gameOver = true;

            if (points1 > points2)
                winner = "Winner is Player 1!";
            else if (points1 < points2)
                winner = "Winner is Player 2!";
            else winner = "Tie!";
        }
    }
}
