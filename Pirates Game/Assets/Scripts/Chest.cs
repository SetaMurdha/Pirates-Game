using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chest : Collectable
{
    public Sprite emptyChest;
    public GameObject soal;
    public int skor = 10;

    protected override void onCollect()
    {
        if (!collected)
        {
            collected = true;
            GetComponent<SpriteRenderer>().sprite = emptyChest;
<<<<<<< HEAD
            soal.SetActive(true);
=======
            GameManager.instance.ShowText(skor.ToString(), 45, Color.yellow, transform.position, Vector3.up * 25, 1.5f);
>>>>>>> 9ae10a7480bd554dbe6288e6c0b5e390eb7a1425
        }
        
    }

}
