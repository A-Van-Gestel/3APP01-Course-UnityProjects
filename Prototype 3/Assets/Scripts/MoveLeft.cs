using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    private float speed = 30.0f;
    private PlayerController _playerControllerScript;
    
    // Start is called before the first frame update
    void Start()
    {
        // Find the "Player" gameObject and get the playerController script from that player.
        _playerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (_playerControllerScript.gameOver == false)
        {
            transform.Translate(Vector3.left * Time.deltaTime * speed);
        }
    }
}
