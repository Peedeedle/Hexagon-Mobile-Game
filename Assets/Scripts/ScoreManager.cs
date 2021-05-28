using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreManager : MonoBehaviour
{
    // public variables and floats to define the high score system
    public Text scoreText;
    public Text hiScoreText;

    public GameObject gameOver;

    public float scoreCount;
    public float hiScoreCount;

    // Points per second as the player is in the level
    public float pointsPerSecond;

    // Determine if the score should still be increasing
    public bool ScoreIncreasing;
    


    // Start is called before the first frame update
    void Start()
    {
        // Get the last high score and set it to the new high score everytime the game is loaded
        if (PlayerPrefs.HasKey("HighScore"))
        {
            hiScoreCount = PlayerPrefs.GetFloat("HighScore");
        }
    }

    // Update is called once per frame
    void Update()
    {

        // Score count will increase if the score increasing is true
        if (ScoreIncreasing)
        {
            // Add Score onto the score count as the game goes on  
            scoreCount += pointsPerSecond * Time.deltaTime;

            if (gameOver.activeInHierarchy)
            {
                ScoreIncreasing = false;
            }

        }

        // Set high score if the score count tries to go above it, save high score
        if (scoreCount > hiScoreCount)
        {
            hiScoreCount = scoreCount;
            PlayerPrefs.SetFloat("HighScore", hiScoreCount);
        }


        // As counter increases add a score onto the score text which is a rounded number
        scoreText.text = "Score: " + Mathf.Round(scoreCount);
        hiScoreText.text = "HighScore: " + Mathf.Round(hiScoreCount);

    }

    // Public value that takes in a whole number to add to the score
    public void AddScore(int pointsToAdd)
    {
        scoreCount += pointsToAdd;
    }








































    /*
    // public variables and floats to define the high score system
    public Text ScoreText;
    public Text HighScoreText;

    public float ScoreCount;
    public float HighScoreCount;

    private void Start()
    {
        // Get the last high score and set it to the new high score everytime the game is loaded
        if (PlayerPrefs.HasKey("HighScore"))
        {
            HighScoreCount = PlayerPrefs.GetFloat("HighScore");
        }
    }

    void Update()
    {
        if (ScoreCount > HighScoreCount)
        {
            HighScoreCount = ScoreCount;
            PlayerPrefs.SetFloat("HighScore", HighScoreCount);
        }

        // As counter increases add a score onto the score text which is a rounded number
        ScoreText.text = "Score: " + Mathf.Round(ScoreCount);
        HighScoreText.text = "HighScore: " + Mathf.Round(HighScoreCount);






        // if player collides with the box collider add 2 score
        void OnTriggerEnter2D(Collider2D other)
        {
            if (other.CompareTag("PointZone"))
            {
                Score++;
                Debug.Log(score);
            }

            {
                if (other.CompareTag("Collider"))
                {
                    Destroy(gameObject);
                    //Debug.Log(death);
                }
            }
        }





    }




    // public score and score text
    //public int score;
    //public int death;
    //public Text scoreDisplay;
    //public Text deathDisplay;



    // Update score display
    private void Update()
    {
        scoreDisplay.text = score.ToString();
        //deathDisplay.text = death.ToString();
    }

    // if player collides with the box collider add 2 score
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("PointZone"))
        {
            score++;
            Debug.Log(score);
        }

        {
            if (other.CompareTag("Collider"))
            {
                Destroy(gameObject);
                //Debug.Log(death);
            }
        }
    }
    */
}



/*Access this script from any other piece of code **
public static ScoreManager instance;

// Keep track of score and highscore
public int score, highScore;

// **
private void Awake()
{
    instance = this;
}

//
public void Addscore()
{
    score++;
}
}

*/




