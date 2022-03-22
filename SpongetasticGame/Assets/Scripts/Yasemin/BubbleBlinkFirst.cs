using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class BubbleBlinkFirst : MonoBehaviour
{
    [SerializeField] GameObject guiBubble;

    void Update()
    {
        StartCoroutine(ShowAndHide());
    }

    IEnumerator ShowAndHide()
    {
        guiBubble.SetActive(true);
        yield return new WaitForSeconds(4);
        Debug.Log("true");
        guiBubble.SetActive(false);
        yield return new WaitForSeconds(4);
        Debug.Log("false");

    }
}