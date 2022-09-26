using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputControll
{
    
    public float movev;
    public float moveh;
    public bool interact;
    public bool menu;
    

    // Update is called once per frame
    
    
        



    public void check()
    {
        movev = Input.GetAxisRaw("Vertical");
        moveh = Input.GetAxisRaw("Horizontal");
        
        interact = Input.GetKeyDown("e");
        
        menu = Input.GetKeyDown("j");
    }
}
