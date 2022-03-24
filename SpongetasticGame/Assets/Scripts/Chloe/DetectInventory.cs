using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectInventory : MonoBehaviour
{
    public static bool itemsGot;
    bool allItems;
    EnterGoal currentGoal;

    private void Start()
    {
        itemsGot = false;
    }
    void Update()
    {
        allItems = true;
        for (int i = 0; i < this.gameObject.transform.childCount; i++)
        {
            GameObject currentChild = this.gameObject.transform.GetChild(i).gameObject;
            currentGoal = currentChild.GetComponent<EnterGoal>();
            foreach (int a in currentGoal.allowedLevels)
            {
                if (a == LevelScript.playerLevel)
                {
                    if (currentGoal.tag != "Untagged")
                    {
                        allItems = false;
                    }
                }
            }
        }
        if (allItems == true)
        {
            itemsGot = true;
        }
    }
}
