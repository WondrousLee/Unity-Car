using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player; //refers to player selected in Unity
    private UnityEngine.Vector3 offset = new UnityEngine.Vector3(0, 4, -13);
    //Default Camera behind player.
    private int currentChoice = 0;
    // Start is called before the first frame update

    UnityEngine.Vector3[] arrCamerasRedTruck = new [] {new UnityEngine.Vector3(0, 4, -13), new UnityEngine.Vector3(0.03f, 1.72f, 3.02f), new UnityEngine.Vector3(-0.031f, 1f, 4.491f)};
    void Start()
    {

    }
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            currentChoice++;
            if (currentChoice == 3){
                currentChoice = 0;
            }
            offset = arrCamerasRedTruck[currentChoice];
        }
    }
        // Update is called once per frame
        // LateUpdate is updating after Update().
        // So after the Update is finished loading logic,
        // LateUpdate runs after that.
        // It's used when updating camera, postprocessing logic or delayed reactions to game events.

        void LateUpdate()
        {
            //so it's just transforming position of camera depending on player (car) postion
            //Additionally offset this by Vector3 (x: +(0), y: +(5), z:+(-10))


            //Ah yes, so i thought about it wrong, you don't want to rotate this
            // beacuse it stays behind player
            // you want to MOVE camera behind player!

            // transform.rotation = player.transform.rotation;

            UnityEngine.Quaternion cameraRotation = player.transform.rotation;
            //Quaternion in VERY basic terms is a Vector3 but for rotation of object.

            transform.rotation = cameraRotation;
            transform.position = player.transform.position + player.transform.rotation * offset;
            // p.t.rotation * offset rotates the OFFSET to the correct position everytime player turns

        }
    }
