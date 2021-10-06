using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        if (GlobalVariables.gameOver)
        {
            if (Input.GetKey(KeyCode.X)) {
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
                GlobalVariables.gameOver = false;
                GlobalVariables.points1 = 0;
                GlobalVariables.points2 = 0;
                GlobalVariables.lives = 10;
                GlobalVariables.winner = "";

                Time.timeScale = 1;
            }
            
        }
    }
}
