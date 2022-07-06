using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckFinish : MonoBehaviour
{
    
    public float slowdownFactor = 0.5f;
    public GameObject FinishPanel;
    public ForwardJump forwardJump;
    public CameraFollow cameraFollow;
    public bool finishedgame;
    void Start()
    {
        finishedgame = false; 
    }
    void Update()
    {

    }
    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player" || other.gameObject.tag == "Collider")
        {
            finishedgame = true;
            cameraFollow.checkfinish = true;
            StartCoroutine("doSlowmotion");       
        }
    }
    void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Player" || other.gameObject.tag == "Collider")
        {
            StartCoroutine("doSlowmotion");
        }
    }
    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player" )
        {
            
        }
    }
    IEnumerator doSlowmotion()
    {
        Time.timeScale = slowdownFactor;
        yield return new WaitForSeconds(0.1f);
        StartCoroutine("finishgamedelay");
    }
    IEnumerator finishgamedelay()
    {   
        Time.timeScale = 1f;
        yield return new WaitForSeconds(2f);
        FinishPanel.SetActive(true);
        StopCoroutine("doSlowmotion");

        forwardJump.gameStart = false;
    }
}
