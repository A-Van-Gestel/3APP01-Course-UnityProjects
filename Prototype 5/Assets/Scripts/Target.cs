using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class Target : MonoBehaviour
{
    private Rigidbody _targetRb;
    private GameManager _gameManager;
    private float _minSpeed = 12;
    private float _maxSpeed = 16;
    private float _maxTorque = 10;
    private float _xRange = 4;
    private float _ySpawnPos = -2;

    public ParticleSystem explosionParticle;
    public int pointValue;
    
    // Start is called before the first frame update
    void Start()
    {
        _targetRb = GetComponent<Rigidbody>();
        _gameManager = GameObject.Find("Game Manager").GetComponent<GameManager>();
        
        _targetRb.AddForce(RandomForce(), ForceMode.Impulse);
        _targetRb.AddTorque(RandomTorque(), RandomTorque(), RandomTorque(), ForceMode.Impulse);

        transform.position = RandomSpawnPos();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        Destroy(gameObject);
        Instantiate(explosionParticle, transform.position, explosionParticle.transform.rotation);
        _gameManager.UpdateScore(pointValue);
    }

    private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
        
        // Trigger game over when any objects that isn't a bad one falls below the screen
        if (!gameObject.CompareTag("Bad"))
        {
            _gameManager.GameOver();
        }
    }

    Vector3 RandomForce()
    {
        return Vector3.up * Random.Range(_minSpeed, _maxSpeed);
    }

    float RandomTorque()
    {
        return Random.Range(-_maxTorque, _maxTorque);
    }

    Vector3 RandomSpawnPos()
    {
        return new Vector3(Random.Range(-_xRange, _xRange), _ySpawnPos);
    }
}
