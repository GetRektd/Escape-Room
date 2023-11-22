using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{

    public GameObject[] enemyPrefabs;

    private float xRange = 2;

    private float spawnPosZ = .5f;

    
    private float spawnInterval = 1.2f;

    private float startDelay = 3;

    int counter = 10;

    public GameObject keyPrefab;



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
         if (counter < 1) 
        {
            CancelInvoke();
            Instantiate(keyPrefab, new Vector3(-2, .5f, .17f), keyPrefab.transform.rotation );
        }

        int sphereIndex =  Random.Range(0, enemyPrefabs.Length);
        Vector3 spawnpos = new Vector3(Random.Range (-xRange, xRange), 0, -4);
        Instantiate(enemyPrefabs[sphereIndex], spawnpos, enemyPrefabs[sphereIndex].transform.rotation);
        counter --;
    }

    




}

