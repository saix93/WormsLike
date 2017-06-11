using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Missile : MonoBehaviour {

    public GameObject explosionPrefab;

    private Rigidbody2D missileRB;

    private void Awake()
    {
        missileRB = this.GetComponent<Rigidbody2D>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log(collision.name);
        Instantiate(explosionPrefab, this.transform.position, this.transform.rotation);

        Destroy(this.gameObject);
    }

    private void Update()
    {
        float angle = 0;

        Vector3 relative = transform.InverseTransformPoint(this.transform.position);
        angle = Mathf.Atan2(relative.x, relative.y) * Mathf.Rad2Deg;
        transform.Rotate(0, 0, angle);
    }
}
