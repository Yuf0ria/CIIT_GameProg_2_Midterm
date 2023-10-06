using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuaternionRotateTowardsExample : MonoBehaviour
{
    // The object whose rotation we want to match.
    public Transform target;



    void Update()
    {
        Vector3 relativePos = target.position - transform.position;


        Quaternion rotation = Quaternion.LookRotation(relativePos, Vector3.up);
        // Rotate our transform a step closer to the target's.
        transform.rotation = rotation;
    }
}
