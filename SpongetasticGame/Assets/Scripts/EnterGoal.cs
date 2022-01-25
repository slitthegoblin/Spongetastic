using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnterGoal : MonoBehaviour
{
    [SerializeField] string objectName;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == objectName)
        {
            this.gameObject.tag = "Untagged";
        }
    }

}
