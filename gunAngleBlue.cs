using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gunAngleBlue : MonoBehaviour
{
    //public float speed = 5f;
    //private float movement = 0f;
    public HingeJoint2D hinge;
    public JointMotor2D motor;

    // Start is called before the first frame update
    void Start()
    {
        hinge = GetComponent<HingeJoint2D>();
        motor = hinge.motor;
    }

    // Update is called once per frame
    void Update()
    {
        if (control.isBlueTurn)
        {
            //Debug.Log("gunAngle - blue");
            if (Input.GetKey(KeyCode.DownArrow))
            {
                motor.motorSpeed = 75;
            }
            else if (Input.GetKey(KeyCode.UpArrow))
            {
                motor.motorSpeed = -75;
            }
            else
            {
                motor.motorSpeed = 0;
            }
                hinge.motor = motor;
                hinge.useMotor = true;
            }
        }
        
}
