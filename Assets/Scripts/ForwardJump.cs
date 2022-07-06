using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForwardJump : MonoBehaviour
{
    public Transform forceTransform;
    Rigidbody rb;
    public float power = 1000f;
    public float torquePower = 10000f;
    public bool grounded;
    public bool flipbool;
    public bool slowDownbool;
    public bool deathbool = false;
    public GameObject FailPanel;
    public int starcounter;
    public int allstarcounter;
    public GameObject InfoPanel;
    public bool gameStart;
    void Start()
    {
        gameStart = false;
        starcounter = 0;
        rb = GetComponent<Rigidbody>();
        flipbool = false;
        slowDownbool = false;
        deathbool = false;
        
    }
    void Update()
    {   
        if(!gameStart)
        {
            rb.constraints = RigidbodyConstraints.FreezeAll;
            if(Input.GetMouseButtonDown(0))
            {
                gameStart = true;
            }
        }
        if (gameStart)
            {
            rb.constraints = RigidbodyConstraints.None | RigidbodyConstraints.FreezeRotationZ | RigidbodyConstraints.FreezeRotationZ | RigidbodyConstraints.FreezeRotationY;   
            }
        

        if (flipbool && grounded)
        {
            ApplyForce();
        }
        if(slowDownbool && !grounded)
        {
            SlowDown();
            Anim();
        }
        if(deathbool)
        {
            FailPanel.SetActive(true);
        }
        if(Input.GetMouseButtonDown(0))
        {
            InfoPanel.SetActive(false);
        }
    }
    void ApplyForce()
    {
        Vector3 direction = forceTransform.position - rb.transform.position;
        rb.AddForce(new Vector3(1,3,0) * power);
        rb.AddRelativeTorque(Vector3.left * torquePower, ForceMode.Impulse);
        
        flipbool = false;
    }

    void Anim()
    {

    }
    void SlowDown()
    {
        rb.AddRelativeTorque(Vector3.right * torquePower/2, ForceMode.Impulse);
        slowDownbool = false;       
    }
    public void SetGroundedState(bool _grounded)
    {
        grounded = _grounded;
    }
}
