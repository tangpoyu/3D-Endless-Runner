using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Service
public class RotateGameObject : MonoBehaviour
{
    [SerializeField]
    private int rotateSpeed = 1;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    { 
        transform.Rotate(0, rotateSpeed, 0,Space.World); // Model [ transform ]
    }
}
