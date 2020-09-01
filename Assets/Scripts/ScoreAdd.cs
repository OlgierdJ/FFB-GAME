using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreAdd : MonoBehaviour
{
    //OnTriggerEnter is called every time an object collides with the hitbox of the object
    //Ups the Score variable in ScoreSystem.Score
    private void OnTriggerEnter2D(Collider2D collision)
    {
        ScoreSystem.Score++;
    }
}
