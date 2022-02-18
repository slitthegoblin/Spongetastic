using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoverOver : MonoBehaviour
{
    [SerializeField] GameObject UIToHide;
    void Start()
    {
        StartCoroutine(ToggleOff());
    }

    void update()
    {
        if (this.gameObject.tag == "Dragging")
        {
            ToggleOff();
        }
    }
    private void OnMouseEnter()
    {
        if (this.gameObject.tag != "Dragging")
        {
            if (this.gameObject.tag != "Draggable")
            {
                StartCoroutine(ToggleOff());
            }
            else
            {
                StartCoroutine(ToggleOn());
            }
        }

    }

    private void OnMouseExit()
    {
        StartCoroutine(ToggleOff());
    }

    private void OnMouseDown()
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
