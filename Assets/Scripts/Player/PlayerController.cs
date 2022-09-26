using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    InputControll ip = new InputControll();
    Rigidbody2D rg;
    public float vel;
    void Start()
    {
        rg = GetComponent<Rigidbody2D>();
        
    }

    // Update is called once per frame
    void Update()
    {
        ip.check();

        rg.velocity = new Vector2 (ip.moveh * vel, ip.movev*vel);

    }
}
