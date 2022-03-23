using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RemoveParent : MonoBehaviour
{
    void Update()
    {
        if (this.gameObject.tag == "Untagged")
        {
            this.transform.parent = null;
        }
    }
}
