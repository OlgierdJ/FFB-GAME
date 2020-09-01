using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FuckingMove : MonoBehaviour
{
    public float speed;
    protected Transform myTransform;
    // Start is called before the first frame update
    // The speed float is set to 4f
    void Start()
    {
        speed = 4f;
    }
    
    // Update is called once per frame
    // This effectively moves the pipes and destroys them when they are out of bounds
    void Update()
    {
        myTransform = GetComponent<Transform>();
        if (myTransform.position.x <= -12f)
        {
            Destroy(gameObject);
        }
        transform.Translate(Vector2.left * speed * Time.deltaTime);
    }
}
