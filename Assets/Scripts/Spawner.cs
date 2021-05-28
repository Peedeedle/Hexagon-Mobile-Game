using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    // Create public spawn rate
    public float spawnRate = 1f;

    // Link to the hexagon prefab
    public GameObject HexagonPrefab;

    // Set time until next hexagon is spawned
    private float nextTimeToSpawn = 0f;



    // Update is called once per frame
    void Update()
    {
        

        // If current time is greater or equal to the next time to spawn, spawn hexagon at centre of the world with no rotation
        if (Time.time >= nextTimeToSpawn)
        {
            Instantiate(HexagonPrefab, Vector3.zero, Quaternion.identity);

            // Set next time to spawn = current time +1 / spawn rate
            nextTimeToSpawn = Time.time + 1f / spawnRate;
        }

    }
}
