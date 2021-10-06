using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using static GlobalVariables;

public class ChangeText : MonoBehaviour
{
    public Text ScoreText;
    public int PlayerNumber;

    void FixedUpdate()
       {
            if (PlayerNumber == 1)
                ScoreText.text = "Score 1: " + points1.ToString();
            else if (PlayerNumber == 2)
                ScoreText.text = "Score 2: " + points2.ToString();
    }
}
