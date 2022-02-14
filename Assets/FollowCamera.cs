using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{

    [SerializeField] GameObject toFollow;

    Vector3 offSet = new Vector3(0,0,10);

    void LateUpdate()
    {
        transform.position = toFollow.transform.position - offSet;
    }
}
