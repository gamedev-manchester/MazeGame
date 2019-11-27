using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateMovement : MonoBehaviour
{

    public float turnSpeed = 100f;
    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.right * turnSpeed * Time.deltaTime);
        
    }
}
