using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moping : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.name == "Water")
        {
            Destroy(col.gameObject);
        }
    }
}
