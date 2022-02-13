using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject enemyPrefab;
    private float _spawnRange = 9.0f;
    
    // Start is called before the first frame update
    void Start()
    {
        SpawnEnemyWave(3);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnEnemyWave(int enemiesToSpawn)
    {
        for (int i = 0; i < enemiesToSpawn; i++)
        {
            // Create a new enemy
            Instantiate(enemyPrefab, GenerateSpawnPosition(), enemyPrefab.transform.rotation);
        }
    }
    
    private Vector3 GenerateSpawnPosition()
    {
        // Generate a random spawn position
        float spawnPosX = Random.Range(-_spawnRange, _spawnRange);
        float spawnPosZ = Random.Range(-_spawnRange, _spawnRange);

       Vector3 randomPos = new Vector3(spawnPosX, 0, spawnPosZ);

       return randomPos;
    }
}
