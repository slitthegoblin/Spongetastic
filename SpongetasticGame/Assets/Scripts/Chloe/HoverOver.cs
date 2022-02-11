using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoverOver : MonoBehaviour
{
    [SerializeField] GameObject UIToHide;
    void Start()
    {
        UIToHide.SetActive(false);
    }
    private void OnMouseEnter()
    {
        StartCoroutine(ToggleOn());
    }

    private void OnMouseExit()
    {
        StartCoroutine(ToggleOff());
    }

    IEnumerator ToggleOn()
    {
        UIToHide.SetActive(true);
        yield return new WaitForSeconds(0.1f);
    }

    IEnumerator ToggleOff()
    {
        UIToHide.SetActive(false);
        yield return new WaitForSeconds(0.1f);
    }
}
