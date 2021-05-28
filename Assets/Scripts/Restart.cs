using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour
{
    // Spawn rate game object
    public GameObject SpawnRate0;


    // When the screen is pressed while the game over screen is active restart the game
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }



}


/*if (gameOver && Time.timeScale == 1f)
    {
    Time.timeScale = 0f;

    }

    else if (!gameOver && Time.timeScale == 0f)
    {
    Time.timeScale = 1f;
    }
    */