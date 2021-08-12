using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collideable : MonoBehaviour
{
    public ContactFilter2D filter;
    private BoxCollider2D bxcldr;
    private Collider2D[] hits = new Collider2D[10];

    protected virtual void Start()
    {
        bxcldr = GetComponent<BoxCollider2D>();
    }

    protected virtual void Update()
    {
        bxcldr.OverlapCollider(filter, hits);
        for (int i = 0; i < hits.Length; i++)
        {
            if (hits[i] == null)
            {
                continue;

            }

            onCollide(hits[i]);

            hits[i] = null;
        }
    }

    protected virtual void onCollide(Collider2D coll)
    {
        Debug.Log(coll.name);
    }

}
