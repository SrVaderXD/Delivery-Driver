using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour // Deals with Collision
{
    
    bool hasPackage = false;
        void OnCollisionEnter2D(Collision2D other)
    {
        Debug.Log("Colliding!!");
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Package")
        {
            Debug.Log("Package picked up!!");
            hasPackage = true;
        }

        else if(other.tag == "Costumer" && hasPackage)
        {
            Debug.Log("Package delivered!!");
            hasPackage = false;
        }
    }
}
