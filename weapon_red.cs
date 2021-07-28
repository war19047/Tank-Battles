using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class weapon_red : MonoBehaviour
{
    public Transform firePoint;
    public GameObject bulletPrefab;
    private bool isMyTurn = false;

    // Update is called once per frame
    void Update()
    {
       if (Input.GetButtonDown("Fire1")) {
           Debug.Log("isBlueTurn (red): "+control.isBlueTurn);
           Debug.Log("isMyTurn- red: "+isMyTurn);
           
           if(isMyTurn)
           {
            fire();
           }
            control.isBlueTurn = isMyTurn;
            isMyTurn = !isMyTurn;
       }
    }
    void fire() {
        //fires the weapon
        Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
    }
}
