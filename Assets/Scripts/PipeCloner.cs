using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeCloner : MonoBehaviour
{
    //Variable pointers are designed here
    public GameObject pipePrefab;
    public Transform pipeSpawn;
    public float min;
    public float max;
    public float timer;

    // Update is called once per frame
    // Checks if the timer that is set in the engine hits 0
    // If that is the case it instantiates new 'Pipes' and sets the timer to a random number between min and max
    // Removes time from the timer at the end
    void Update()
    {
        if (timer <= 0)
        {
            Instantiate(pipePrefab, pipeSpawn.position, pipeSpawn.rotation);
            timer = Random.Range(min, max);
        }
        timer -= Time.deltaTime;
    }
}
