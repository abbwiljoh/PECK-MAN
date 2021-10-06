using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOverMessage : MonoBehaviour
{
    public Text GameOverText;
    public Text RestartText;
    public Text WinnerText;
    public Text DeathText;
    public Text RespawnText;
    public Text DeathTextBackground;

    // Update is called once per frame
    void Update()
    {
        if (GlobalVariables.gameOver)
        {
            DeathTextBackground.text = "";
            DeathText.text = "";
            RespawnText.text = "";
            GameOverText.text = "GAME OVER!";
            RestartText.text = "Press X to Restart";
            WinnerText.text = GlobalVariables.winner;

            Time.timeScale = 0;
        }
        else
        {
            Time.timeScale = 1;
            GameOverText.text = "";
            RestartText.text = "";
            WinnerText.text = "";
        }
    }
}
