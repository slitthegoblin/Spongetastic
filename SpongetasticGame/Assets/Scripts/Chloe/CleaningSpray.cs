using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CleaningSpray : MonoBehaviour
{
    [SerializeField] GameObject bubbles;
    [SerializeField] Vector3 spawnPosition;
    [SerializeField] string sprayName;
    [SerializeField] GameObject parent;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == sprayName)
        {
            GameObject newBubbles = Instantiate(bubbles, spawnPosition, this.transform.rotation, parent.gameObject.transform) as GameObject;
            Destroy(this.gameObject);
        }
    }
}
