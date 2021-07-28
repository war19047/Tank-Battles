/*
Example script to move a player.
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movePlayer : MonoBehaviour
{
    public float speed = 5f;
    private float movement = 0f;
    private Rigidbody2D rigidbody;

    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(control.isBlueTurn)
        {
            movement = Input.GetAxis("Horizontal");
            // Change the velocity attribute under rigidbody.
            rigidbody.velocity = new Vector2(movement * speed, rigidbody.velocity.y);
        }
    }
}
