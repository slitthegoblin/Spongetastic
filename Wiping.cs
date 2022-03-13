using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wiping : MonoBehaviour
{

    SpriteRenderer sprite;

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.name == "Mess")
        {
            sprite = col.GetComponent<SpriteRenderer>();
            sprite.color = new Color(sprite.color.r, sprite.color.g, sprite.color.b, sprite.color.a - 0.2f);
        }
        if (sprite.color.a < 0)
        {
            Destroy(col.gameObject);
        }
    }

}
