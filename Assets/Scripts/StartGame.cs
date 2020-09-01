using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour
{
    // Update is called once per frame
    // two if statements, one is checking on 'space' KeyDown, resets score and loads the Game scene
    // the other checks on escape and Quits the application (the .exe)
    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            ScoreSystem.Score = 0;
            SceneManager.LoadScene("Game");
        }
        if (Input.GetKeyDown("escape"))
        {
            Application.Quit();
        }
    }
}
