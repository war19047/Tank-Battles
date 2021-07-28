using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move_horizontal_red : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed;
    public float moveVelocity;

    // Update is called once per frame
    void Update()
    {
        moveVelocity = 0;

        if ((Input.GetKey (KeyCode.A) || Input.GetKey (KeyCode.LeftArrow)) && !control.isBlueTurn){
            moveVelocity = -speed; // move left.
        }

        if ((Input.GetKey (KeyCode.D) || Input.GetKey (KeyCode.RightArrow)) && !control.isBlueTurn){
            moveVelocity = speed; // move right.
        }

        GetComponent<Rigidbody2D> ().velocity = new Vector2 (moveVelocity, GetComponent<Rigidbody2D> () .velocity.y);
    }
}
