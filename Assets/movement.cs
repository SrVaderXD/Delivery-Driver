using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{

    [SerializeField] float rotationSpeed = 0.6f;
    [SerializeField] float moveSpeed = 0.015f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float rotationDirection = Input.GetAxis("Horizontal");
        float moveDirection = Input.GetAxis("Vertical");
        transform.Rotate(0, 0, -rotationDirection * rotationSpeed);
        transform.Translate(0, moveSpeed * moveDirection, 0);
    }
}
