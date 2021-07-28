using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class weapon : MonoBehaviour
{
    public Transform firePoint;
    public GameObject bulletPrefab;
    private bool isMyTurn = true;
    //move_horizontal moveH = new move_horizontal();
    //gunAngle gAngle = new gunAngle();

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1")) {
            Debug.Log("isBlueTurn: "+control.isBlueTurn);
            Debug.Log("isMyTurn- blue: " + isMyTurn);
            
            if(isMyTurn)
            {
                fire();
            }
            control.isBlueTurn = !isMyTurn;
            isMyTurn = !isMyTurn;
       }
    }

    void fire() {
        //fires the weapon
        Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
    }
}