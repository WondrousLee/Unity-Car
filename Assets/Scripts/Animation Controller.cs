using System.Collections;
using System.Collections.Generic;
using System.Security;
using UnityEngine;

public class animationController : MonoBehaviour
{

    public GameObject player;
    public GameObject wheel_fl;
    public GameObject wheel_fr;
    public GameObject wheel_rl;
    public GameObject wheel_rr;

    //import currentSpeed for animations.
    private float RotationSpeed = 5f;
    private PlayerController playerController;
    // Start is called before the first frame update
    void Start()
    {
        playerController = GetComponent<PlayerController>();

    }

    // Update is called once per frame
    void Update()
    {


        // transform.Translate(Vector3.forward * Time.deltaTime * CurrentSpeed, Space.Self);

        // if (CurrentSpeed < 0)
        // {
        //     CurrentSpeed += 1f * Time.deltaTime;
        // }
        // else
        // {
        //     CurrentSpeed -= 1f * Time.deltaTime;
        // }

        //also could not finish, some issue with not correctly rotating, i might've been too tired to see what im doing, yes!

        // if (wheel_fl.transform.rotation.eulerAngles.y >= -80 && wheel_fr.transform.rotation.eulerAngles.y >= -80
        //  && wheel_fl.transform.rotation.eulerAngles.y <= 80 && wheel_fr.transform.rotation.eulerAngles.y <= 80 
        //  && horizontalInput != 0)
        // {
        //     wheel_fl.transform.Rotate(0, wheelSpeed * horizontalInput, 0);
        //     wheel_fr.transform.Rotate(0, wheelSpeed * horizontalInput, 0);
        // }

        // if (Input.GetKey(KeyCode.A))
        // {
        //     wheel_fl.transform.Rotate(Vector3.up * Time.deltaTime * -RotationSpeed, Space.Self);
        // }

        // if (Input.GetKey(KeyCode.D))
        // {
        //     wheel_fl.transform.Rotate(Vector3.up * Time.deltaTime * RotationSpeed, Space.Self);
        // }
    }
}
