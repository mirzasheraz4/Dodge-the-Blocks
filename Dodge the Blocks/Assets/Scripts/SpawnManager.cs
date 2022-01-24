using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject blocks;
    private float spawnRangeX = 4;
    private float spawnPoseY = 5.5f;
    private int startDelay = 2;
    private float spawnInterval = 1.5f;
    int [] spawnlocations = new int[4]  { -3, -1, 1, 3};
    


    private void Start()
    {
        InvokeRepeating("SpawnRandomBlocks", startDelay, spawnInterval);

    }

    void SpawnRandomBlocks()
    {
        int ran = Random.Range(0, spawnlocations.Length);
        Vector2[] spawnPos = new Vector2[4];
        for (int i=0; i<spawnlocations.Length; i++)
        {
            spawnPos[i] = new Vector2(spawnlocations[i], spawnPoseY);
        }

        for (int i = 0; i < spawnlocations.Length; i++){
            if (ran != i)
            {
                Instantiate(blocks, spawnPos[i], blocks.transform.rotation);
            }
            
        }
        

    }
}
