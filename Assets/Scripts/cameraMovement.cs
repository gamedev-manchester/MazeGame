using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraMovement : MonoBehaviour
{

    private Vector3 offset;
    public GameObject sphere;
    // Start is called before the first frame update
    void Start()
    {
        //Store the distance between the camera and the sphere.
        offset = transform.position - sphere.transform.position;
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        //Set camera follow the sphere.
        transform.position = sphere.transform.position + offset;
        
    }
}
