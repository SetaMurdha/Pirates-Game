using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chest : Collectable
{
    public Sprite emptyChest;
    public int skor = 10;

    protected override void onCollect()
    {
        if (!collected)
        {
            collected = true;
            GetComponent<SpriteRenderer>().sprite = emptyChest;
            GameManager.instance.ShowText(skor.ToString(), 45, Color.yellow, transform.position, Vector3.up * 25, 1.5f);
        }
        
    }
}
