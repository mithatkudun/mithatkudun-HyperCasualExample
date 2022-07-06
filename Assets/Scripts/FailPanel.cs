using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FailPanel : MonoBehaviour
{
    public ForwardJump forwardJump;
public void RestartButton()
    {
        forwardJump.gameStart = false;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
