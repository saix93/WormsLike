using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowMouse : MonoBehaviour {

    public float zPosition = -2;

    void Update () {
        Vector3 mouse = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        this.transform.position = new Vector3(mouse.x, mouse.y, zPosition);

    }
}
