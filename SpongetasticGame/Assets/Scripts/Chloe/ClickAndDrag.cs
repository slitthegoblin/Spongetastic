using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickAndDrag : MonoBehaviour
{
    [SerializeField] private AudioSource source;
    public Vector3 mousePosition;
    GameObject draggedObject;
    Vector3 startPosition;
    public static ClickAndDrag clickdrag;

    void Start()
    {
        clickdrag = this;
    }
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);
            if (hit.collider != null)
            {
                if (hit.transform.gameObject.CompareTag ("Draggable"))
                {
                    source.Play();
                    hit.transform.tag= "Dragging";
                    startPosition = hit.transform.gameObject.transform.position;
                    draggedObject = hit.transform.gameObject;
                }
            }
        }

        if (Input.GetMouseButton(0))
        {
            if (draggedObject != null)
            {
                if (draggedObject.tag == "Dragging")
                {
                    mousePosition.x = Input.mousePosition.x;
                    mousePosition.y = Input.mousePosition.y;
                    mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);
                    mousePosition.z = startPosition.z;
                    draggedObject.transform.gameObject.transform.position = mousePosition;
                }
            }
        }

        else if (Input.GetMouseButtonUp(0))
        {
            if (draggedObject != null)
            {
                if (draggedObject.tag == "Dragging")
                {
                    draggedObject.transform.gameObject.transform.position = startPosition;
                    draggedObject.tag = "Draggable";
                }
                draggedObject = null;
            }
        }
        
    }
}
