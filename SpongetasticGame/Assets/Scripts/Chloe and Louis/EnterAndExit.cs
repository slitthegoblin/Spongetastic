using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class EnterAndExit : MonoBehaviour
{

    public int iLevelToLoad;
    public string sLevelToLoad;

    public bool useIntegerToLoadLevel = false;

    [SerializeField] int levelNumber;
    int currentLevel = LevelScript.playerLevel;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        GameObject collisionGameObject = collision.gameObject;

        if(collisionGameObject.name == "Player")
        {
            LoadScene();
        }
    }

    public void LoadScene()
    {
        currentLevel = LevelScript.playerLevel;

        if (useIntegerToLoadLevel)
        {
            SceneManager.LoadScene(iLevelToLoad);
        }
         else
        {
            if (currentLevel == levelNumber) {
                if (DetectInventory.itemsGot == true) {
                    SceneManager.LoadScene(sLevelToLoad);
                }
            }

            if (levelNumber == 0)
            {
                SceneManager.LoadScene(sLevelToLoad);
            }
        }
    }
}
