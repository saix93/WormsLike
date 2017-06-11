using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraZoom : MonoBehaviour {

    public float zoomSpeed = 4;
    public float maxZoom = 10;
    public float minZoom = 50;

	void Update () {
        Camera.main.orthographicSize = Mathf.Clamp(Camera.main.orthographicSize + -Input.GetAxis("Mouse ScrollWheel") * zoomSpeed, maxZoom, minZoom);
    }
}
