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
            Destroy(this.gameObject);
        }
        
    }
}
