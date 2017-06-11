using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bazooka : MonoBehaviour {

    public GameObject missilePrefab;
    public Transform shootingPoint;

    public float shootingForce = 30;

    void Update () {
        if (Input.GetButtonDown("Fire1"))
        {
            GameObject missile = Instantiate(missilePrefab, shootingPoint.position, shootingPoint.rotation);

            missile.GetComponent<Rigidbody2D>().AddForce(transform.up * shootingForce);
        }
    }
}
