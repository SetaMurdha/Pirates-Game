using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : Collideable
{
    public float msgTime = 6.0f;
    public float lastMsg = 10.0f;
    public string msg;

    protected override void onCollide(Collider2D coll)
    {
        if (coll.name == "Player" && Time.time - lastMsg > msgTime) {
            lastMsg = Time.time;
            GameManager.instance.ShowText(msg, 50, Color.black, transform.position, Vector3.up * 25, 5.0f);
        }
    }
}
