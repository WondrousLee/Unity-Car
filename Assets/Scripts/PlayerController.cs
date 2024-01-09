using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;
using UnityEngine.Jobs;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private float speed = 25.0f;
    private float turnSpeed = 40f;
    public float horizontalInput;
    public float verticalInput;
    // Update is called once per frame
    void Update()
    {
        //Move the vehicle forward!
        verticalInput = Input.GetAxis("Vertical");
        transform.Translate(UnityEngine.Vector3.forward * Time.deltaTime * speed * verticalInput);

        //Turn the vehicle by rotating object
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Rotate (0, Time.deltaTime * horizontalInput * turnSpeed, 0);


    }
}
