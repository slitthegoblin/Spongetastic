using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchSprite : MonoBehaviour
{
    [SerializeField] GameObject basketFull;
    [SerializeField] GameObject checking;

    private void Start()
    {
        StartCoroutine(ToggleObject(false));
    }
    void Update()
    {
        if (checking.transform.childCount == 0)
        {
            StartCoroutine(ToggleObject(true));
        }
    }

    IEnumerator ToggleObject(bool on)
    {
        basketFull.SetActive(on);

        yield return new WaitForSeconds(0.1f);
    }
}
