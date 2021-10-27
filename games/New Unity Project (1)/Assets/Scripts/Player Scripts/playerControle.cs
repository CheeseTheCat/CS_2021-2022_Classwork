using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playerControle : MonoBehaviour
{
    public int playerLives = 3;
    public int score;
    public UIScript ui;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void addScore(int amount)
    {
        score += amount;
        ui.setScoreText(score);
    }

    public void gameOver()
    {
        playerLives --;
        if (playerLives >= 0)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
        else
        {
            SceneManager.LoadScene("GameOver");
        }
         
    }
}
