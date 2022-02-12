using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    public float timeBetweenKeyPresses = 1.0f;
    public float keyPressTimer = 0.0f;

    // Update is called once per frame
    void Update()
    {
        
        // On spacebar press && timer less then set delay time, send dog
        if (Input.GetKeyDown(KeyCode.Space) && keyPressTimer >= timeBetweenKeyPresses)
        {
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            // Reset the timer to 0
            keyPressTimer = 0;
        }
        
        // Increase the timer
        keyPressTimer += 1 * Time.deltaTime;
    }
}
