using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIScript : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    // Start is called before the first frame update
    void Start()
    {
        setScoreText(0);
    }

    public void setScoreText (int score)
    {
        scoreText.text = "Score: " + score.ToString();
    }
}
