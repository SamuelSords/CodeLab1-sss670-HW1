using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float Force = 10;
    Rigidbody2D rb;
    // Start is called before the first frame update
    void Start() //setup
    {
        Debug.Log("Hello, World!");
        rb = GetComponent<Rigidbody2D>();

        //rb.AddForce(Vector2.right * Force);
    }

    // Update is called once per frame
    void Update() //draw
    {
        Debug.Log("Goodbye, World!");

        if(Input.GetKey(KeyCode.D))
        {
            rb.AddForce(Vector2.right * Force);
        }
        if(Input.GetKey(KeyCode.S))
        {
            rb.AddForce(Vector2.down * Force);
        }
        if (Input.GetKey(KeyCode.W))
        {
            rb.AddForce(Vector2.up * Force);
        }
        if (Input.GetKey(KeyCode.A))
        {
            rb.AddForce(Vector2.left * Force);
        }
    }
}
