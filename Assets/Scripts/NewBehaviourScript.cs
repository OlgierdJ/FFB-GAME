using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public Rigidbody2D rb;
    // Start is called before the first frame update
    // In start the Rigidbody2D pointer 'rb' is defined
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    // Vector and transform variables are defined
    // Then checks if the KeyDown is equal to space
    // If that is the case then it applies vertical force upwards on the object running the script
    void Update()
    {
        Vector2 move = new Vector2(0, Mathf.Clamp(rb.velocity.y, 0f, 2f));
        transform.position = new Vector2(0f, transform.position.y);
        if (Input.GetKeyDown("space"))
        {
            rb.velocity = move;
            rb.AddForce(new Vector2(0, 5),ForceMode2D.Impulse);
        }
    }
}
