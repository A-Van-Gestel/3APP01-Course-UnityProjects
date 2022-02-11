using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisions : MonoBehaviour
{
    // When the object collides with an other object
    private void OnTriggerEnter(Collider other)
    {
        // Destroy both objects
        Destroy(gameObject);
        Destroy(other.gameObject);
    }
}
