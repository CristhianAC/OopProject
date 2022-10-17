using System.Collections;
using System.Collections.Generic;
using UnityEngine.Events;
using UnityEngine;

public class Mouse_Cursor : MonoBehaviour
{
    static public Vector3 pos;
    public static GameObject selected;
    public bool isTouchingObject;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.visible = true;
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);
        transform.position = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        isTouchingObject = (hit.collider != null) && (hit.collider.tag == "Interactable Object");
        if (hit && hit.collider.tag == "Interactable Object")
        {
            selected = hit.collider.gameObject;
        }
        else
        {
            selected = null;
        }
    }
}

