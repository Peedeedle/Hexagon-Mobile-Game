using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Player : MonoBehaviour
{


    
    // public float to move depending on speed
    public float moveSpeed = 300f;

    // Stored in a float variable so the movement is not called in "update"
    float movement = 0f;
    



    // Array for the Hexagons
    private PublicHexagon[] HexagonList;

    // Game object and score manager references
    public GameObject gameOver;
    public GameObject Spawner;

    public ScoreManager theScoreManager;




    
    // Update is called once per frame, only allow to move along the horizontal axis
    public void Update()
    {
        movement = (Input.GetAxis("Fire1"));
        //DetectInput();

        /*
        MoveLeft();
        {
            transform.RotateAround(Vector3.zero, Vector3.forward, -movement * Time.fixedDeltaTime * moveSpeed);
        }

        MoveRight();
        {
            transform.RotateAround(Vector3.zero, Vector3.back, movement * Time.fixedDeltaTime * moveSpeed);
        }
        */

    }
    


    // Fixed update function
    private void FixedUpdate()
    {
        // If the mouse is pressed on the left side of the screen execute code
        if (Input.mousePosition.x < Screen.width / 2 && (Input.GetAxis("Fire1") > 0f))
        {
            // Rotate left
            transform.RotateAround(Vector3.zero, Vector3.forward, -movement * Time.fixedDeltaTime * -moveSpeed);
            Debug.Log("You Moved Left");
        }


        // If the mouse is pressed on the right side of the screen execute code
        else if (Input.mousePosition.x > Screen.width / 2 && (Input.GetAxis("Fire1") > 0f))
        {
            // Rotate right
            transform.RotateAround(Vector3.zero, Vector3.forward, movement * Time.fixedDeltaTime * -moveSpeed);
            Debug.Log("You Moved Right");
        }
        
    }



    // On collision re load active scene, stop spawning hexagons and make the game over menu active
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Collider"))
        {
            gameOver.SetActive(true);
            gameObject.SetActive(false);
            Spawner.SetActive(false);

        }

        if (other.CompareTag("PointZone"))
        {
            //Score++;
        }


    }






    /*
    if (Input.GetAxis("Fire1") > 0f)
    {
        transform.RotateAround(Vector3.zero, Vector3.forward, movement * Time.fixedDeltaTime * moveSpeed);

    }
    */















    /*
    // Rotate around the specific point / centre of the screen, angle you move depends on the movement
    public void MoveLeft()
    {
        // Move Left
        //if (Input.GetKeyDown(KeyCode.A))
        {
            transform.RotateAround(Vector3.zero, Vector3.forward, -movement * Time.fixedDeltaTime * moveSpeed);
            Debug.Log("You Moved Left");
        }
    }

    public void MoveRight()
    { 
        // movement Right
        //if (Input.GetKeyDown(KeyCode.D))
        //{
            transform.RotateAround(Vector3.zero, Vector3.back, movement * Time.fixedDeltaTime * moveSpeed);
            Debug.Log("You Moved Right");
        //}
    }
      
    */

    /*
    void DetectInput()
    {
        float x = Input.GetAxisRaw("Horizontal");

        if (x > 0)
        {
            MoveRight();
        }

        else if (x < 0)
        {
            MoveLeft();
        }

    }
    */






}
