using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosion : MonoBehaviour {

    public float explosionRadius = 30;

    public LayerMask layerMask;

    private void Start()
    {
        Collider2D[] colliders = Physics2D.OverlapCircleAll(this.transform.position, explosionRadius, layerMask);

        for (int i = 0; i < colliders.Length; i++)
        {
            if (colliders[i].isTrigger == false)
            {
                Destroy(colliders[i].gameObject);
            }
        }

        Destroy(this.gameObject);
    }
}
