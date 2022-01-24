using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnterGoal : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Goal")
        {
            this.gameObject.tag = "Untagged";
        }
    }
}
