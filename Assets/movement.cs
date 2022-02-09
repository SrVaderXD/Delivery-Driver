using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{

    [SerializeField] float rotationSpeed = 200f;
    [SerializeField] float moveSpeed = 15f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float rotationDirection = Input.GetAxis("Horizontal") * Time.deltaTime;
        float moveDirection = Input.GetAxis("Vertical") * Time.deltaTime;
        transform.Rotate(0, 0, -rotationDirection * rotationSpeed);
        transform.Translate(0, moveSpeed * moveDirection, 0);
    }
}
