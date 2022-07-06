using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckHit : MonoBehaviour
{
    RigidbodyConstraints originalConstraints;
    Rigidbody rb;
    public GameObject blood;
    ForwardJump forwardJump;
    public CheckFinish checkFinish;

    void Start()
    {   

        forwardJump = GetComponentInParent<ForwardJump>();
        rb = GetComponentInParent<Rigidbody>();
        originalConstraints = rb.constraints;
    }
    void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "Collectable")
        {
            forwardJump.starcounter++;
            forwardJump.allstarcounter++;
        }
        if (collider.gameObject.tag == "Untagged")
        {   
            if(!checkFinish.finishedgame)
            {
                if (blood)
                    BloodEffect();
            }
            
        }

        
    }
    void OnCollisionEnter(Collision collider)
    {
        if (collider.gameObject.tag == "Collectable")
        {
            forwardJump.starcounter++;
            forwardJump.allstarcounter++;
        }
        if (collider.gameObject.tag == "Untagged")
        {
            if (!checkFinish.finishedgame)
            {
                if (blood)
                    BloodEffect();
            }
        }


    }
    void BloodEffect()
    {
      GameObject bloodEffect;
      bloodEffect =  Instantiate(blood, this.gameObject.transform.position, Quaternion.identity);
      bloodEffect.transform.parent = gameObject.transform;
        rb.constraints = RigidbodyConstraints.FreezeAll;
        Destroy(bloodEffect, 10);
        forwardJump.deathbool = true;
    }
}
