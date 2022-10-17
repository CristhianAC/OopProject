using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class interactableObject : MonoBehaviour
{
    public dialogueObject dialogue;
    public bool isToggled;
    private bool touchingMouselastframe;
    public bool touchingMouse;
    [SerializeField] private GameObject border;
    public UnityEvent onTouchingMouse;
    public UnityEvent onMouseClick;
    public UnityEvent onToggleOn;
    public UnityEvent onToggleOff;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        touchingMouse = Mouse_Cursor.selected == this.gameObject;
        border.SetActive(touchingMouse);
        if (!touchingMouselastframe && touchingMouse)
        {
            onTouchingMouse.Invoke();
        }
        if (touchingMouse && Input.GetMouseButtonDown(0))
        {
            onMouseClick.Invoke();
            if (isToggled)
            {
                onToggleOff.Invoke();
            }
            else
            {
                onToggleOn.Invoke();
            }
            isToggled = !isToggled;
        }
    }
    private void LateUpdate()
    {
        touchingMouselastframe = touchingMouse;
    }


}
