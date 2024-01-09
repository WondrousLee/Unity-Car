using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpcomingTraffic : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed = 30f;
    private PlayerController playerController;
    public Object traffic;
    void Start()
    {
        playerController = GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(UnityEngine.Vector3.forward * Time.deltaTime * speed);

        if (transform.position.Equals(playerController.transform.position.z + 4)){
            Object.Destroy(traffic);
        }
    }
}
