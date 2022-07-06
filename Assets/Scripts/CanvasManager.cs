using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class CanvasManager : MonoBehaviour
{
    [SerializeField] public int starcounter;

    public TMP_Text levelIndex;
    public TMP_Text starsText;
    public TMP_Text starsText1;
    public Image finishFill;
    public GameObject finishObject;
    public ForwardJump forwardJump;
    int sceneIndex;
    public GameObject pausePanel;
    public bool pause = false;
    public GameObject[] starsobject;
    void Start()
    {

        sceneIndex = SceneManager.GetActiveScene().buildIndex - 1;
        forwardJump.flipbool = false;
        forwardJump.slowDownbool = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(pause)
        {
            PauseGame();
        }
        if(!pause)
        {
            ResumeGame();
        }
        
        finishFill.fillAmount = forwardJump.transform.position.x / finishObject.transform.position.x;
        levelIndex.text = sceneIndex.ToString();
        starsText.text = forwardJump.allstarcounter.ToString()+" X";
        starsText1.text = forwardJump.allstarcounter.ToString() + " X";

        if (forwardJump.starcounter == 1)
        {
            starsobject[0].SetActive(true);
        }
        if (forwardJump.starcounter == 2)
        {
            starsobject[0].SetActive(true);
            starsobject[1].SetActive(true);
        }
        if (forwardJump.starcounter == 3)
        {
            starsobject[0].SetActive(true);
            starsobject[1].SetActive(true);
            starsobject[2].SetActive(true);
        }
    }
    void PauseGame()
    {
        pausePanel.SetActive(true);
        Time.timeScale = 0f;        
    }
    void ResumeGame()
    {
        pausePanel.SetActive(false);
        Time.timeScale = 1f;       
    }
    public void FlipButton()
    {
        if (!forwardJump.grounded)
        {
            return;
        }
        forwardJump.flipbool = true;
    }
    public void SlowDownButton()
    {
        if (forwardJump.grounded)
        {
            return;
        }
        forwardJump.slowDownbool = true;
    }
    public void PauseButton()
    {
        pause = true;
    }
    public void ResumeButton()
    {
        pause = false;
    }
    public void RestartButton()
    {
        forwardJump.gameStart = false;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    public void NextLevelButton()
    {
        forwardJump.gameStart = false;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void LevelsScene()
    {
        SceneManager.LoadScene("Levels");   
    }
}
