using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelIncreaser : MonoBehaviour
{
    public void Pass()
    {
        int currentLevel = SceneManager.GetActiveScene().buildIndex;

        if (currentLevel >= PlayerPrefs.GetInt("Level Unlocked"))
        {
            PlayerPrefs.SetInt("Level Unlocked", currentLevel + 1);
        }
        Debug.Log("LEVEL " + PlayerPrefs.GetInt(("Level Unlocked") + "UNLOCKED"));
    }
}
