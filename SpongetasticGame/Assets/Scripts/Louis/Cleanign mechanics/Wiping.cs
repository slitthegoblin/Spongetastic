using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wiping : MonoBehaviour
{
   

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.name == "Mess")
        {
            Destroy(col.gameObject);
        }
    }

}
