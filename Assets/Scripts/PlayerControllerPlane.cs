using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerPlane : MonoBehaviour
{
    public float speed = 0.3f;
    public float rotationSpeed = 20f;
    public float verticalInput;
    public float horizontalInput;
    public float propellerSpeed = 100000f;

    public GameObject propeller;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        // get the user's vertical input
        verticalInput = Input.GetAxis("Vertical");
        horizontalInput = Input.GetAxis("Horizontal");

        // move the plane forward at a constant rate
        transform.Translate(Vector3.forward * speed);

        // tilt the plane up/down based on up/down arrow keys
        transform.Rotate(verticalInput * Vector3.right * rotationSpeed * Time.deltaTime);

        // tilt the plane left and right.
        transform.Rotate(horizontalInput * new Vector3(0,0,-1) * rotationSpeed * Time.deltaTime);

        //Propeller animation
        propeller.transform.Rotate(0, 0, 2 * propellerSpeed * Time.deltaTime);
    }
}
