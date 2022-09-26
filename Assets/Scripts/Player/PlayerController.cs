using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    InputControll ip = new InputControll();
    Rigidbody2D rg;
    Animator anim;
    public float vel;

    bool isFacingRight = true;

    void Start()
    {
        rg = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
       
    }

    // Update is called once per frame
    void Update()
    {
        ip.check();

        rg.velocity = new Vector2 (ip.moveh * vel, ip.movev*vel);
        
        
    }
    private void FixedUpdate()
    {
        if (ip.moveh < 0 && isFacingRight)
        {
            Flip();
        } else if (ip.moveh > 0 && !isFacingRight)
        {
            Flip();
        }
    }
    private void LateUpdate()
    {
        if (ip.moveh!=0 || ip.movev != 0) {
            anim.SetBool("Walking", true);
        }
        else
        {
            anim.SetBool("Walking", false);
        }
    }
    protected void Flip()
    {
        isFacingRight = !isFacingRight;

        Vector3 theScale = transform.localScale;
        theScale.x *= -1;
        transform.localScale = theScale;

        
        
    }
}
