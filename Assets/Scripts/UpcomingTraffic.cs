using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpcomingTraffic : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed = 30f;
    public PlayerController playerController;
    public Object traffic;
    // Start is called before the first frame update
    void Start()
    {

        GameObject vehUteRedZ = GameObject.Find("Veh_Ute_Red_Z");
        //Finds player

        // Checks if game object is found
        if (vehUteRedZ != null)
        {
            // Gets player component PlayerController
            playerController = vehUteRedZ.GetComponent<PlayerController>();

            // Checks if playercontroller is found, otherwise log it!
            if (playerController == null)
            {
                Debug.Log("PlayerController - component not found on: 'Veh_Ute_Red_Z'");
            }
        }
        else
        {
            Debug.Log("'Veh_Ute_Red_Z': not found.");
        }
    }
    // Update is called once per frame
    void Update()
    {
        if (traffic != null && playerController != null)
        {
            transform.Translate(UnityEngine.Vector3.forward * Time.deltaTime * speed);
            if (Mathf.Abs(transform.position.z - (playerController.transform.position.z - 4)) < 0.1f)
            //Yes i know sometimes they don't disapear.
            {
                Object.Destroy(traffic); //Destroys the traffic after player goes past it.
            }
            else
            {
                if (traffic == null)
                {
                    Debug.Log("Traffic object is null!");
                }
            }
        }
    }
}
