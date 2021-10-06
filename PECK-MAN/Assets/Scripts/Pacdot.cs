using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static GlobalVariables;

public class Pacdot : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D co)
    {
        if (co.name == "pacman")
        {
            GlobalVariables.points1 += 1;
            Destroy(gameObject);
        }
        if (co.name == "pocman")
        {
            GlobalVariables.points2 += 1;
            Destroy(gameObject);
        }
    }
}
