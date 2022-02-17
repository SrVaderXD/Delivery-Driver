using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{

    [SerializeField] float rotationSpeed = 200f;
    [SerializeField] float moveSpeed = 15f;
    [SerializeField] float slowSpeed = 5f;
    [SerializeField] float boostSpeed = 20f;
  
    // Update is called once per frame
    void Update()
    {
        float rotationDirection = Input.GetAxis("Horizontal") * Time.deltaTime;
        float moveDirection = Input.GetAxis("Vertical") * Time.deltaTime;
        transform.Rotate(0, 0, -rotationDirection * rotationSpeed);
        transform.Translate(0, moveSpeed * moveDirection, 0);
    }

    void OnCollisionEnter2D(Collision2D collisionInfo)
    {
        moveSpeed = slowSpeed;
    }

    void OnTriggerEnter2D(Collider2D other) 
    {
        if (other.tag == "speedBoost") 
            moveSpeed = boostSpeed;
    }
}
