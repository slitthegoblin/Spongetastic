using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnterGoal : MonoBehaviour
{
    [SerializeField] string objectName;
    [SerializeField] float finalX;
    [SerializeField] float finalY;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == objectName)
        {
            this.gameObject.tag = "Untagged";
            this.gameObject.transform.position = new Vector3(finalX, finalY, this.gameObject.transform.position.z);
        }
    }

}
