using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    private float _spawnRangeX = 20;
    private float _spawnPosZ = 20;
    private float _startDelay = 2;
    private float _spawnInterval = 1.5f;
    
    // Start is called before the first frame update
    void Start()
    {
        // Repeatably call "SpawnRandomAnimal" starting at 2 seconds, repeating every 1.5 seconds
        InvokeRepeating("SpawnRandomAnimal", _startDelay, _spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void SpawnRandomAnimal()
    {
        // Randomly generate an animal index and spawn position
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        Vector3 spawnPos = new Vector3(Random.Range(-_spawnRangeX, _spawnRangeX), 0, _spawnPosZ);
            
        Instantiate(animalPrefabs[animalIndex], spawnPos, animalPrefabs[animalIndex].transform.rotation);
    }
}
