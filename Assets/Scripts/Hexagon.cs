using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hexagon : MonoBehaviour
{

    // Create a public "rb" to reference the 2D Rigidbody
    public Rigidbody2D rb;

    // Public float for hexagons shrink speed
    public float shrinkSpeed = 3f;

    // Start is called before the first frame update
    void Start()
    {
        // Set random rotation for hexagon rigidbody between 0 and 360
        rb.rotation = Random.Range(0f, 360f);
        transform.localScale = Vector3.one * 10f;
    }

    // Update is called once per frame
    void Update()
    {
        // Shrink hexagon 
        transform.localScale -= Vector3.one * shrinkSpeed * Time.deltaTime;

        // If the hexagon is smaller than 0.5f delete it
        if (transform.localScale.x <= .05f)
        {
            Destroy(gameObject);
        } 

    }
}
