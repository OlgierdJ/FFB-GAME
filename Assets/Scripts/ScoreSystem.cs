using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class ScoreSystem : MonoBehaviour
{
    public static int Score;
    public GameObject scoreText;
    // Start is called before the first frame update
    // scoreText is checking for a GameObject named Text and pointing to it
    void Start()
    {
        scoreText = GameObject.Find("Text");
    }

    // Update is called once per frame
    // The scoreText text is updated to display the current score.
    void Update()
    {
        scoreText.GetComponent<Text>().text = Score.ToString();
    }
}