using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOver : MonoBehaviour
{
    public Text GameOverText;
    public Text GameOverTextBackground;
    public Text RespawnTextBackground;
    public Text RespawnText;

    // Update is called once per frame
    void Update()
    {
        if (!GlobalVariables.gameOver) 
        {
            if (GlobalVariables.GameOver1 || GlobalVariables.GameOver2)
            {
                Time.timeScale = 0;
            
                RespawnText.text = "Press R to Respawn";
                if (GlobalVariables.GameOver1) 
                {    
                    GameOverText.text = "Player One Died!";
                }
                else if (GlobalVariables.GameOver2)
                {
                    GameOverText.text = "Player two died!";
                }

                if (Input.GetKey(KeyCode.R))
                {
                    GlobalVariables.lives -= 1;
                    GlobalVariables.GameOver2 = false;
                    GlobalVariables.respawn2 = true;
                    GlobalVariables.GameOver1 = false;
                    GlobalVariables.respawn1 = true; 
                }
            }
            else
            {
                GameOverText.text = "";
                RespawnText.text = "";
                Time.timeScale = 1;
            }
        }
    }
}
