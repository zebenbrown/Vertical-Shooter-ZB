using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    private GameOver gameOver;
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI highScoreNumber;
    public TextMeshProUGUI highScoreText;
    public TextMeshProUGUI FinalScoreText;
    public int currentScore;
    public void Start()
    {
        currentScore = 0;
        UpdateScoreDisplay();

        highScoreText.text = "High Score: ".ToString();
        highScoreNumber.text = PlayerPrefs.GetInt("HighScore", 0).ToString();
    }

    public void addScore(int pointsToAdd)
    {
        currentScore += pointsToAdd;

        UpdateScoreDisplay();

        if (currentScore > PlayerPrefs.GetInt("HighScore", 0))
        {
            PlayerPrefs.SetInt("HighScore", currentScore);
            highScoreNumber.text = currentScore.ToString();
        }
    }
    public void UpdateScoreDisplay()
    {
            scoreText.text = "Score: " + currentScore.ToString();
            PlayerPrefs.SetInt("CurrentScore", currentScore);
    }
}