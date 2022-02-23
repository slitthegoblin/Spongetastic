using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sweeping : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.name == "Dust")
        {
            Destroy(col.gameObject);
        }
    }
}
