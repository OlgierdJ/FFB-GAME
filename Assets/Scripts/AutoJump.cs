using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoJump : MonoBehaviour
{
    public Rigidbody2D rb;
    // Start is called before the first frame update
    // In start the Rigidbody2D pointer 'rb' is defined
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    /* Update is used for making the bird apply vertical
     * force upwards if it falls below a certain 'y' coordinate
     */
    void Update()
    {
        Vector2 move = new Vector2(0, Mathf.Clamp(rb.velocity.y, 0f, 2f));
        transform.position = new Vector2(0f, transform.position.y);
        if (transform.position.y <= -2)
        {
            rb.velocity = move;
            rb.AddForce(new Vector2(0, 5), ForceMode2D.Impulse);
        }
    }
}
