using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject obstaclePrefab;
    private Vector3 _spawnPos = new Vector3(25, 0, 0);
    private float _startDelay = 2.0f;
    private float _repeatRate = 2.0f;
    private PlayerController _playerControllerScript;
    
    // Start is called before the first frame update
    void Start()
    {
        // Find the "Player" gameObject and get the playerController script from that player.
        _playerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();
        
        // Spawns obstacles on a set repeater
        InvokeRepeating(nameof(SpawnObstacle), _startDelay, _repeatRate);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnObstacle()
    {
        if (_playerControllerScript.gameOver == false)
        {
            // Spawn a new obstacle
            Instantiate(obstaclePrefab, _spawnPos, obstaclePrefab.transform.rotation);
        }
    }
}
