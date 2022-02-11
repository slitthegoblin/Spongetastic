using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickToHide : MonoBehaviour
{
    [SerializeField] GameObject UIToHide;
    bool ActiveObject;
    GameObject clickedObject;
    void Start()
    {
        UIToHide.SetActive(false);
        ActiveObject = false;
    }

    IEnumerator ToggleObject(bool IsActive)
    {

        if (IsActive == false)
        {
            UIToHide.SetActive(true);
            yield return new WaitForSeconds(0.1f);
            ActiveObject = true;
        }
        else
        {
            UIToHide.SetActive(false);
            yield return new WaitForSeconds(0.1f);
            ActiveObject = false;
        }
    }


    private void OnMouseDown()
    {
        RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);
        if (hit.collider != null)
        {
            if (hit.transform.gameObject.CompareTag("Hideable"))
            {
                clickedObject = hit.transform.gameObject;
                if (clickedObject == this.gameObject)
                {
                    StartCoroutine(ToggleObject(ActiveObject));
                }
            }
        }
    }
}
