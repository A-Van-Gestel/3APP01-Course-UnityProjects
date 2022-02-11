using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    private float _topBound = 30;
    private float _lowerBound = -10;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z > _topBound)
        {
            Destroy(gameObject);
        } else if (transform.position.z < _lowerBound)
        {
            Destroy(gameObject);
        }
    }
}
