using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelUp : MonoBehaviour
{
    void Update()
    {
        if (this.transform.childCount == 0)
        {
            LevelScript.LS.IncreaseLevel();
            DetectInventory.itemsGot = false;
            Destroy(this.gameObject);
        }
        
    }
}
