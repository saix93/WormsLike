using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generator : MonoBehaviour {

    public GameObject dirtPrefab;
    public GameObject grassPrefab;

    public int minX = -120;
    public int maxX = 120;
    public int minY = -50;
    public int maxY = 50;

    public long seed = 123456789L;

    private PerlinNoise noise;

    private void Start()
    {
        seed = Random.Range(1, 10000000);
        noise = new PerlinNoise(seed);
        Regenerate();
    }

    private void Regenerate()
    {

        float width = dirtPrefab.transform.lossyScale.x;
        float height = dirtPrefab.transform.lossyScale.y;

        for (int i = minX; i < maxX; i++)
        {
            int columnHeight = 2 + noise.GetNoise(i - minX, maxY - minY - 2);
            for (int j = minY; j < minY + columnHeight; j++)
            {
                GameObject block = (j == minY + columnHeight - 1) ? grassPrefab : dirtPrefab;
                Instantiate(block, new Vector2(i * width, j * height), Quaternion.identity);
            }
        }
    }
}
