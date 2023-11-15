using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{

    public GameObject[] enemyPrefabs;

    private float xRange = 2;

    private float spawnPosZ = 4;
    
    private float spawnInterval = 1.2f;

    private float startDelay = 3;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating ("SpawnRandomBalls", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnRandomBalls ()

    {

        int sphereIndex =  Random.Range(0, enemyPrefabs.Length);
        Vector3 spawnpos = new Vector3(Random.Range (-xRange, xRange), spawnPosZ);
        Instantiate(enemyPrefabs[sphereIndex], spawnpos, enemyPrefabs[sphereIndex].transform.rotation);
    }

}

