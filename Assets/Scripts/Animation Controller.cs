using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animationController : MonoBehaviour
{

    public GameObject wheel_fl;
    public GameObject wheel_fr;
    public GameObject wheel_rl;
    public GameObject wheel_rr;

    private float wheelSpeed = 23f;
    private PlayerController playerController;
    // Start is called before the first frame update
    void Start()
    {
        playerController = GetComponent<PlayerController>();

    }

    // Update is called once per frame
    void Update()
    {
        //rotate wheels while riding forward.
        float verticalInput = playerController.verticalInput;
        wheel_fl.transform.Rotate(wheelSpeed * verticalInput, 0, 0);
        wheel_fr.transform.Rotate(wheelSpeed * verticalInput, 0, 0);
        wheel_rl.transform.Rotate(wheelSpeed * verticalInput, 0, 0);
        wheel_rr.transform.Rotate(wheelSpeed * verticalInput, 0, 0);

        float horizontalInput = playerController.horizontalInput;

        //rotate wheels while turning
        //Probably the most unoptimized sh*t you'll ever see.

        //also could not finish, some issue with not correctly rotating, i might've been too tired to see what im doing, yes!

        // if (wheel_fl.transform.rotation.eulerAngles.y >= -80 && wheel_fr.transform.rotation.eulerAngles.y >= -80
        //  && wheel_fl.transform.rotation.eulerAngles.y <= 80 && wheel_fr.transform.rotation.eulerAngles.y <= 80 
        //  && horizontalInput != 0)
        // {
        //     wheel_fl.transform.Rotate(0, wheelSpeed * horizontalInput, 0);
        //     wheel_fr.transform.Rotate(0, wheelSpeed * horizontalInput, 0);
        // }
        // else if (wheel_fr.transform.rotation.eulerAngles.y != 0 || wheel_fl.transform.rotation.eulerAngles.y != 0)
        // {
        //     wheel_fl.transform.rotation = new Quaternion(0, 0, 0, 0);
        //     wheel_fl.transform.rotation = new Quaternion(0, 0, 0, 0); // Resets to original rotation
        // }
        // else
        // {
        //     Debug.Log("Do not do stuff!");
        // }
    }
}
