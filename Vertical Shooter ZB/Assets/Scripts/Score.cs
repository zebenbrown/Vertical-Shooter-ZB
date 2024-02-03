using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    private int score;
    private void Start()
    {
        score = 0;
        UpdateScoreDisplay();

    }

    public void addScore(int pointsToAdd)
    {
        score += pointsToAdd;
        UpdateScoreDisplay();
    }
    void UpdateScoreDisplay()
    {
        if (scoreText != null)
        {
            scoreText.text = "Score: " + score.ToString();
        }

        else
        {
            Debug.Log("Score text is null");
        }
    }
}