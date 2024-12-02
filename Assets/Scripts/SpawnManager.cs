using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalsPrefabs;
    private float spawnRangeX = 20;
    private float spawnPosZ = 20;
    private float startDelay = 2f;
    private float spawnInterval = 2f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating(nameof(SpawnRandomAnimals), startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {
    }

    void SpawnRandomAnimals()
    {
        int animalIndex = Random.Range(0, animalsPrefabs.Length);
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);
        Instantiate(animalsPrefabs[animalIndex], spawnPos, animalsPrefabs[animalIndex].transform.rotation);
    }
}