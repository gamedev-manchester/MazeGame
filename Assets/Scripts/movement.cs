using System.Collections;
using UnityEngine;

public class movement : MonoBehaviour
{

    public float speed;
    private Rigidbody sphere;
    
    // Start is called before the first frame update
    void Start()
    {
        sphere = GetComponent<Rigidbody>();
        
    }
    // Update is called once per frame
    void FixedUpdate()
    {
        float moveX = Input.GetAxis("Horizontal");
        float moveZ = Input.GetAxis("Vertical");

        Vector3 movementVector = new Vector3(moveX,0.0f , moveZ);
        sphere.AddForce(movementVector * speed);
        
    }

   
}
