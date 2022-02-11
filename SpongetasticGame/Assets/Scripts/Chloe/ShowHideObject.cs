using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowHideObject : MonoBehaviour
{
    [SerializeField] GameObject UIToHide;
    public static ShowHideObject ShowHide;
    // Start is called before the first frame update
    void Start()
    {
        UIToHide.SetActive(false);
        ShowHide = this;
    }

    // Update is called once per frame

    public void RunCoroutine()
    {
        StartCoroutine(ToggleObject());
    }

    IEnumerator ToggleObject()
    {
        UIToHide.SetActive(true);

        yield return new WaitForSeconds (1);

        UIToHide.SetActive(false);
    }
}
