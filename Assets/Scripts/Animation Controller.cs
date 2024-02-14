using System.Collections;
using System.Collections.Generic;
using System.Security;
using UnityEngine;
using UnityEngine.AI;

public class animationController : MonoBehaviour
{

    public GameObject player;
    public GameObject[] wheelsSpinning;

    //import 
    private float RotationSpeed = 300f;
    private PlayerController playerController;
    // Start is called before the first frame update
    void Start()
    {
        // Gets player component PlayerController
        playerController = GetComponent<PlayerController>();

        // Checks if playercontroller is found, otherwise log it!
        if (playerController == null)
        {
            Debug.Log("PlayerController - component not found on: 'Veh_Ute_Red_Z'");
        }
    }

    // Update is called once per frame
    void Update()
    {
        foreach (GameObject wheels in wheelsSpinning)
        {
            if (wheels != null) // To avoid errors when it's not detected or destroyed or sth
            {
                //Rotating wheels when vehicle is moving forward (check speed)
                if (playerController.CurrentSpeed < -0.005)
                {
                    wheels.transform.Rotate(Vector3.left * Time.deltaTime * -RotationSpeed * playerController.CurrentSpeed, Space.Self);
                }

                if (playerController.CurrentSpeed > 0.005)
                {
                    wheels.transform.Rotate(Vector3.right * Time.deltaTime * RotationSpeed * playerController.CurrentSpeed, Space.Self);
                }
            }
            //I would add rotation on steering left and right but don't know how.
            //It breaks whole animation when i do that ;/
        }
    }
}