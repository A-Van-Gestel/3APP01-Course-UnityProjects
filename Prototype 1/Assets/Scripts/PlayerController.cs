using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerController : MonoBehaviour
{
    // Private Variables
    [SerializeField] private float speed;
    [SerializeField] private float horsePower = 20000.0f;
    private const float TurnSpeed = 35.0f;
    private float _horizontalInput;
    private float _forwardInput;
    private Rigidbody _playerRb;
    [SerializeField] private GameObject centerOfMass;
    [SerializeField] private TextMeshProUGUI speedometerText;

    void Start()
    {
        _playerRb = GetComponent<Rigidbody>();
        _playerRb.centerOfMass = centerOfMass.transform.position;
    }
    
    // Update is called once per frame
    void FixedUpdate()
    {
        // This is where we get player input
        _horizontalInput = Input.GetAxis("Horizontal");
        _forwardInput = Input.GetAxis("Vertical");
        
        // Move the vehicle forward
        // transform.Translate(Vector3.forward * Time.deltaTime * speed * _forwardInput);
        _playerRb.AddRelativeForce(Vector3.forward * horsePower * _forwardInput);
        // We turn the vehicle
        transform.Rotate(Vector3.up, Time.deltaTime * TurnSpeed * _horizontalInput);
        
        speed = Mathf.RoundToInt(_playerRb.velocity.magnitude * 3.6f); // K/h = * 3.6 || M/h = * 2.237f
        speedometerText.SetText("Speed: " + speed + "kph");
    }
}
