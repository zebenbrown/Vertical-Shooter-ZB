// GameOver.cs (or any other relevant script)
using UnityEngine;
using TMPro;

public class GameOver : MonoBehaviour
{
    public TextMeshProUGUI FinalScoreText;
    public TextMeshProUGUI highScoreNumber;
    int currentScore;


    private void Start()
    {
        Display();
    }

    public void Display()
    {
        currentScore = PlayerPrefs.GetInt("CurrentScore");

        FinalScoreText.text = "Final Score: " + currentScore.ToString();
        highScoreNumber.text = "High Score: " + PlayerPrefs.GetInt("HighScore").ToString();
    }
}
