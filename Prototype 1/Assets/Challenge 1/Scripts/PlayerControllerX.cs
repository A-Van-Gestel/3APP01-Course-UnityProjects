using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    private float _speed = 0.4f;
    private float _rotationSpeed = 3.0f;
    private float _verticalInput;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        // get the user's vertical input
        _verticalInput = Input.GetAxis("Vertical");

        // move the plane forward at a constant rate
        transform.Translate(Vector3.forward * _speed);

        // tilt the plane up/down based on up/down arrow keys
        transform.Rotate(Vector3.right * _rotationSpeed * _verticalInput);
    }
}
