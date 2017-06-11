using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

    public GameObject explosionPrefab;

    private void Start()
    {
        Cursor.visible = false;
    }

    void Update () {
		if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }

        /* if (Input.GetButtonDown("Fire1"))
        {
            Instantiate(explosionPrefab, Camera.main.ScreenToWorldPoint(Input.mousePosition), Quaternion.identity);
        } */
	}
}
