using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObjects : MonoBehaviour
{
    Vector3 startPosition;
    GameObject clickedObject;
    [SerializeField] float objectX;
    [SerializeField] float objectY;
    [SerializeField] float objectZ;
    Vector3 movePosition;

    private void Start()
    {
        startPosition = this.gameObject.transform.position;
        movePosition = new Vector3(objectX, objectY, objectZ);
    }
    private void OnMouseDown()
    {
        RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);
        if (hit.collider != null)
        {
            if (hit.transform.gameObject.CompareTag("Moveable"))
            {
                clickedObject = hit.transform.gameObject;
                if (clickedObject == this.gameObject)
                {
                    if (this.transform.position == startPosition)
                    {
                        this.gameObject.transform.position = movePosition;
                    }
                    else if (this.transform.position == movePosition)
                    {
                        this.gameObject.transform.position = startPosition;
                    }
                }
            }
        }
    }

}
