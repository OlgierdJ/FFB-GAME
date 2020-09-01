using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FckingDeadOnImpact : MonoBehaviour
{
    /* OnCollisionEnter2D is called whenever any object hits the object running the script
     * It checks whether the object colliding with it has the name 'PlayerModel'
     * If that is the case then it transfers the score onto another script and loads the menu scene
     */
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "PlayerModel")
        {
            MenuScore.Score = ScoreSystem.Score;
            SceneManager.LoadScene("Menu");
        }
    }
}
