using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    [SerializeField] string sceneName;
    void Start()
    {
        
    }

    public void loadScene()
    {
        SceneManager.LoadScene(sceneName);
    }
}
