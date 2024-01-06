using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player; //refers to player selected in Unity
    private UnityEngine.Vector3 offset = new UnityEngine.Vector3(0, 4, -13);
    
    
    // Start is called before the first frame update
    void Start()
    {
        
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
        transform.position = player.transform.position + offset;
    }
}
