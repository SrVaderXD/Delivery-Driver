using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour // Deals with Collision
{
    
    bool hasPackage = false;
    [SerializeField] float destroyDelay = 0.5f;
        void OnCollisionEnter2D(Collision2D other)
    {
        Debug.Log("Colliding!!");
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Package" && !hasPackage)
        {
            Debug.Log("Package picked up!!");
            hasPackage = true;
            Destroy(other.gameObject, destroyDelay);
        }

        else if(other.tag == "Costumer" && hasPackage)
        {
            Debug.Log("Package delivered!!");
            hasPackage = false;
        }
    }
}
