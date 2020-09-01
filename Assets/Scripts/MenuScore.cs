using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.UI;

public class MenuScore : MonoBehaviour
{
    public static int Score;
    public GameObject scoreText;
    // Start is called before the first frame update
    // Here the program looks for the object with the name 'Text' and then sets the 'scoreText' to point at that object
    // The gameobjects text components text is then concatenated using a text and the score variable
    void Start()
    {
        scoreText = GameObject.Find("Text");
        scoreText.GetComponent<Text>().text = $"Score: {Score.ToString()}";
    }
}
