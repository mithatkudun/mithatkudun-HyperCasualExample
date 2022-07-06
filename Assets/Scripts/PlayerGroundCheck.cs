using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerGroundCheck : MonoBehaviour
{
    ForwardJump forwardJump;

    void Awake()
    {
        forwardJump = GetComponentInParent<ForwardJump>();
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == forwardJump.gameObject)
        {
            return;
        }
        if (other.gameObject.tag == "Collectable")
        {
            return;
        }
        forwardJump.SetGroundedState(true);
    }
    void OnTriggerStay(Collider other)
    {
        if (other.gameObject == forwardJump.gameObject)
        {
            return;
        }
        if (other.gameObject.tag == "Collectable")
        {
            return;
        }
        forwardJump.SetGroundedState(true);
    }
    void OnTriggerExit(Collider other)
    {
        if (other.gameObject == forwardJump.gameObject)
        {
            return;
        }
        if (other.gameObject.tag == "Collectable")
        {
            return;
        }
        forwardJump.SetGroundedState(false);
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject == forwardJump.gameObject)
        {
            return;
        }
        if(collision.gameObject.tag == "Collectable")
        {
            return;
        }
        forwardJump.SetGroundedState(true);
    }
    void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject == forwardJump.gameObject)
        {
            return;
        }
        if (collision.gameObject.tag == "Collectable")
        {
            return;
        }
        forwardJump.SetGroundedState(true);
    }
    void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject == forwardJump.gameObject)
        {
            return;
        }
        if (collision.gameObject.tag == "Collectable")
        {
            return;
        }
        forwardJump.SetGroundedState(false);
    }
}

