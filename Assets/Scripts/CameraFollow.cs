using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    Transform playerBallTransform;
    public bool checkfinish;
    void Start()
    {
        checkfinish = false;
        playerBallTransform = GameObject.FindGameObjectWithTag("Player").transform;
    }
    void FixedUpdate()
    {   
        if(!checkfinish)
        {
            this.transform.position = playerBallTransform.position + new Vector3(18f, 63.5f, -160f);
        }
        else
        {
            this.transform.position = this.transform.position;
        }
        
    }
}
