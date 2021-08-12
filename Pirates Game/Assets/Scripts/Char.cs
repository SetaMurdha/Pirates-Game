using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Char : MonoBehaviour
{
    BoxCollider2D bxcldr;
    Animator anim;
    Vector3 moveDelta;
    RaycastHit2D hit;

    // Start is called before the first frame update
    void Start()
    {
        bxcldr = GetComponent<BoxCollider2D>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        playerMove();
    }

    void playerMove()
    {
        float moveX = Input.GetAxis("Horizontal");
        float moveY = Input.GetAxis("Vertical");

        moveDelta = new Vector3(moveX, moveY, 0);

        hit = Physics2D.BoxCast(transform.position, bxcldr.size, 0, new Vector2(0, moveDelta.y), Mathf.Abs(moveDelta.y * Time.deltaTime), LayerMask.GetMask("Actor", "Blocking"));
        if(hit.collider == null)
        {
            transform.Translate(0, moveDelta.y * Time.deltaTime, 0);
        }

        hit = Physics2D.BoxCast(transform.position, bxcldr.size, 0, new Vector2(moveDelta.x, 0 ), Mathf.Abs(moveDelta.x * Time.deltaTime), LayerMask.GetMask("Actor", "Blocking"));
        if (hit.collider == null)
        {
            transform.Translate(moveDelta.x * Time.deltaTime,0, 0);
        }

        if (moveX ==0 && moveY == 0)
        {
            anim.SetBool("Walk", false);
        }
        else
        {
            anim.SetBool("Walk", true);
        }

        if (moveDelta.x > 0)
        {
            transform.localScale = Vector3.one;

        }
        else if (moveDelta.x < 0)
        {
            transform.localScale = new Vector3(-1, 1, 1);
        }

        
    }

}
