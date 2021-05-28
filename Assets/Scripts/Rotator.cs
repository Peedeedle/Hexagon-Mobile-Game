using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }


    // Slowly rotate the camera around the scene
    void Update()
    {
        // Rotate camera around Z axis
        transform.Rotate(Vector3.forward, Time.deltaTime * 30f);
    }
}
