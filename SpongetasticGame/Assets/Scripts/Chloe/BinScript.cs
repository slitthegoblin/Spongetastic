using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BinScript : MonoBehaviour
{
    [SerializeField] string trigger;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == trigger)
        {
            Destroy(this.gameObject);
        }
    }
}
