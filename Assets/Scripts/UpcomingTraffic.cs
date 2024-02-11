using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpcomingTraffic : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed = 30f;
    private PlayerController playerController;
    public Object traffic;
    // Start is called before the first frame update
    void Start()
    {
        playerController = GetComponent<PlayerController>();

        if (playerController == null)
        {
            Debug.LogError("PlayerController component not found on the GameObject.");
        }
    }

    // Update is called once per frame
    void Update()
    {

        if (traffic != null && playerController != null)
        {
            transform.Translate(UnityEngine.Vector3.forward * Time.deltaTime * speed);
            if (Mathf.Abs(transform.position.z - (playerController.transform.position.z + 4)) < 0.1f)
            {
                Object.Destroy(traffic);
            }
            else
            {
                if (traffic == null)
                {
                    Debug.LogError("Traffic object is null!");
                }
            }
        }
    }
}
