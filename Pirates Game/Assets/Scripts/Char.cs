using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Char : Mover
{
    private void FixedUpdate()
    {
        float moveX = Input.GetAxis("Horizontal");
        float moveY = Input.GetAxis("Vertical");

        UpdateMotor(new Vector3(moveX, moveY, 0));


        if (moveX == 0 && moveY == 0)
        {
            anim.SetBool("Walk", false);
        }
        else
        {
            anim.SetBool("Walk", true);
        }

    }

}
