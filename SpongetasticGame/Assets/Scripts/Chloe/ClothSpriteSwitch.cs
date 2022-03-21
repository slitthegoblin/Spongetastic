using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClothSpriteSwitch : MonoBehaviour
{

    [SerializeField] GameObject clothFolded;
    [SerializeField] GameObject clothUnfolded;
    private void Update()
    {
        if (this.gameObject.tag == "Draggable")
        {
            StartCoroutine(ShowObject(clothFolded));
            StartCoroutine(HideObject(clothUnfolded));
        }

        if (this.gameObject.tag == "Dragging")
        {
            StartCoroutine(ShowObject(clothUnfolded));
            StartCoroutine(HideObject(clothFolded));
        }

        IEnumerator ShowObject(GameObject UIToShow)
        {
            UIToShow.SetActive(true);

            yield return new WaitForSeconds(0.1f);
        }

        IEnumerator HideObject(GameObject UIToShow)
        {
            UIToShow.SetActive(false);

            yield return new WaitForSeconds(0.1f);
        }
    }
}
