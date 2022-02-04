using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System;

public class LevelScript : MonoBehaviour
{
    public int playerLevel;
    string currentSceneName;
    public static LevelScript LS;

    void Start()
    {
        LS = this;
        Scene currentScene = SceneManager.GetActiveScene();
        currentSceneName = currentScene.name;
    }
    void Update()
    {
        CheckLevel();
        //Debug.Log(playerLevel);
    }

    void CheckLevel()
    {
        char[] split = currentSceneName.ToCharArray();
        foreach (char i in split)
        {
            //Debug.Log(i);
            if (char.IsDigit(i))
            {
                int intValue = (int)Char.GetNumericValue(i);
                playerLevel = intValue;
            }
        }
    }
}
