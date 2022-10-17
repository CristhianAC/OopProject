using UnityEngine;

namespace InputC
{
    public class InputControll
    {
        public float movev;
        public float moveh;
        public bool interact;
        public bool Backpack;

        public InputControll()
        {
             movev = 0f;
             moveh = 0f;
             interact = false;
             Backpack = false;

        }

        // Update is called once per frame






        public void check()
        {
            movev = Input.GetAxisRaw("Vertical");
            moveh = Input.GetAxisRaw("Horizontal");

            interact = Input.GetKeyDown("e");

            Backpack = Input.GetKeyDown("j");
        }
    }
 }

