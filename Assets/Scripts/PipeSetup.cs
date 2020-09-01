using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSetup : MonoBehaviour
{
    //Pointers are defined here
    public float topmin;
    public float topmax;
    public GameObject top;
    public GameObject bottom;

    // Start is called before the first frame update
    // random float is generated between topmin and topmax values
    // then we transform the position of the top pipe to a new position
    // bottom pipe is then set relative to the top pipe
    void Start()
    {
        float temp = Random.Range(topmin, topmax);
        top.transform.position = new Vector2(transform.position.x, temp);
        bottom.transform.position = new Vector2(transform.position.x, temp - 18f);
    }
}
