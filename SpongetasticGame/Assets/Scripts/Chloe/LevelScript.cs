using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System;

public class LevelScript : MonoBehaviour
{
    public static int playerLevel = 1;
    //string currentSceneName;
    public static LevelScript LS;

    void Start()
    {
        LS = this;
    }

    public void SetLevel(int levelNumber)
    {
        playerLevel = levelNumber;
    }

    public void IncreaseLevel()
    {
        playerLevel = playerLevel + 1;
    }
   
}
