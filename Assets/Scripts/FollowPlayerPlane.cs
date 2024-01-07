using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;

public class FollowPlayerPlane : MonoBehaviour
{
    public GameObject plane;
    private UnityEngine.Vector3 offset = new UnityEngine.Vector3(0, 3, -16);
    public float rotationSpeed = 100f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        UnityEngine.Quaternion cameraRotation = plane.transform.rotation;
        transform.rotation = cameraRotation;
        UnityEngine.Vector3 desiredPosition = plane.transform.position + cameraRotation*offset;

        //It does not work as intended, it's quite rough
        // UnityEngine.Vector3 slowedCamera = UnityEngine.Vector3.Lerp(transform.position, desiredPosition, Time.deltaTime * rotationSpeed);
        // transform.position = slowedCamera;

        transform.position = desiredPosition;
    }   
}
