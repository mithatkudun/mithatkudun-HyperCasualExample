using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jumper : MonoBehaviour
{
    public Rigidbody chickenrb;
    public float power = 20f;
    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag =="Player")
        {
            chickenrb.AddForce(new Vector3(0, 3, 0) * power);
            Debug.Log("hit");
        }
    }
    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag =="Player")
        {
            return;
        }
    }

}
