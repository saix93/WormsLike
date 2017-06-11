using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraDrag : MonoBehaviour {

    public float dragSpeed = 2;
    private Vector3 dragOrigin;

    public Generator generator;

    void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            dragOrigin = Input.mousePosition;
            return;
        }

        if (!Input.GetMouseButton(1))
        {
            Cursor.lockState = CursorLockMode.None;

            return;
        }
        
        Cursor.lockState = CursorLockMode.Confined;

        Vector2 pos = Camera.main.ScreenToViewportPoint(Input.mousePosition - dragOrigin);

        Vector2 move = new Vector2(pos.x * dragSpeed, pos.y * dragSpeed);

        transform.Translate(move, Space.World);

        Vector3 transformPosition = transform.position;

        transformPosition.x = Mathf.Clamp(transformPosition.x, generator.minX / 2, generator.maxX / 2);
        transformPosition.y = Mathf.Clamp(transformPosition.y, generator.minY / 4, generator.maxY / 4);

        transform.position = transformPosition;
    }
}
