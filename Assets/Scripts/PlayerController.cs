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
    private float turnSpeed = 15f;

    //Change later to private (inputs)
    public float horizontalInput;
    public float verticalInput;

    //This might need to be Public for later on.
    public float CurrentSpeed = 0f;

    //Car stats, or something like that.
    private float speedPower = 20;
    private float breakPower = 2;
    private float speedBackwardsPower = 5;


    //do not change for now, this is okay!
    //This is stats that are larped for better steering.
    private float maxTurnSpeed = 20f;
    private float minTurnSpeed = 40f;
    private float maxSpeed = 60f;
    void Update()
    {


        //Move the vehicle forward! && Turn the vehicle by rotating object
        float adjustedTurnSpeed = Mathf.Lerp(minTurnSpeed, maxTurnSpeed, CurrentSpeed / maxSpeed); //feels good right now.
        //Except for when you try to rotate vehicle when it's only starting, then it feels
        //weird a little bit because suddenly you can do full rotation at 0.2 speed (let's say 20 km/h?)
        //Yea... I'mn not gonna fix it as it's a small object but it's something to keep in mind.
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");

        if (CurrentSpeed < 0)
        {
            transform.Translate(UnityEngine.Vector3.forward * Time.deltaTime * CurrentSpeed * speedBackwardsPower);
            CurrentSpeed += 0.25f* Time.deltaTime;
        }
        else
        {
            CurrentSpeed -= 0.25f * Time.deltaTime;
            transform.Translate(UnityEngine.Vector3.forward * Time.deltaTime * CurrentSpeed * speedPower);
        }
        if (verticalInput > 0)
        {
            if (CurrentSpeed*10 <= maxSpeed){
            CurrentSpeed += Time.deltaTime;
            }
        }
        if (verticalInput < 0)
        {
            CurrentSpeed -= Time.deltaTime * breakPower;
        }
        //When car is stationary you cannot turn it!
        if (CurrentSpeed > 0.1 || CurrentSpeed < -0.1){
            transform.Rotate (0, Time.deltaTime * horizontalInput * adjustedTurnSpeed, 0);
        }
        //Debug.Log(CurrentSpeed); //i won't add speedometer, it's small project, don't want to over-scope it
    }
}
