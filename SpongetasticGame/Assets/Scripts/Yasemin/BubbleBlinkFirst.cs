using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class BubbleBlinkFirst : MonoBehaviour
{
    public GameObject guiBubble;
    void Start()
    {
        StartCoroutine(ShowAndHide());
    }

    IEnumerator ShowAndHide()
    {
            guiBubble.SetActive(true);
            yield return new WaitForSeconds(5);
            guiBubble.SetActive(false);
    }
}
