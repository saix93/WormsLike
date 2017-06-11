using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PerlinNoise {

    private long seed;

    public PerlinNoise(long seed)
    {
        this.seed = seed;
    }

    private int MyRandom(int x, int range)
    {
        return (int)((x + seed) ^ 5) % range;
    }

    public int GetNoise(int x, int range)
    {
        int chunkSize = 16;

        float noise = 0;

        range /= 2;
        
        while(chunkSize > 0)
        {
            int chunkIndex = x / chunkSize;

            float prog = (x % chunkSize) / (chunkSize * 1f);

            float leftRandom = MyRandom(chunkIndex, range);
            float rightRandom = MyRandom(chunkIndex + 1, range);

            noise += (1 - prog) * leftRandom + prog * rightRandom;

            chunkSize /= 2;
            range /= 2;

            range = Mathf.Max(1, range);
        }

        return (int)Mathf.Round(noise);
    }
}
