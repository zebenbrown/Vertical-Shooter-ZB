using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI highScoreNumber;
    public TextMeshProUGUI highScoreText;
    public int score;
    private void Start()
    {
        score = 0;
        UpdateScoreDisplay();

        highScoreText.text = "High Score: ".ToString();
        highScoreNumber.text = PlayerPrefs.GetInt("HighScore", 0).ToString();

    }

    public void addScore(int pointsToAdd)
    {
        score += pointsToAdd;
        UpdateScoreDisplay();
        if (score > PlayerPrefs.GetInt("HighScore", 0))
        {
            PlayerPrefs.SetInt("HighScore", score);
            highScoreNumber.text = score.ToString();
        }
    }
    void UpdateScoreDisplay()
    {
            scoreText.text = "Score: " + score.ToString();
    }


}