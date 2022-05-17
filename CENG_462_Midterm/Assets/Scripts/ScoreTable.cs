using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//This script is for saving and show top 3 scores and player names
//For saving data I used PlayerPerfs
public class ScoreTable : MonoBehaviour
{

    [SerializeField] private TMPro.TextMeshProUGUI[] nameText;
    [SerializeField] private TMPro.TextMeshProUGUI[] scoreText;

    private void Start()
    {
        HihghestScoreAndNames();
        PrintResult();
    }


    private static void HihghestScoreAndNames()
    {
        PlayerPrefs.SetInt("playerScore", Score.totalScore);
        var playerName = PlayerPrefs.GetString("playerName");
        PlayerPrefs.Save();




        if (!PlayerPrefs.HasKey("playerScore0"))
        {
            PlayerPrefs.SetInt("playerScore0", Score.totalScore);
            PlayerPrefs.SetString("playerName0", playerName);
            PlayerPrefs.Save();
        }

        else if (!PlayerPrefs.HasKey("playerScore1"))
        {
            if (Score.totalScore > PlayerPrefs.GetInt("playerScore0"))
            {
                int tempScore = PlayerPrefs.GetInt("playerScore0");
                string tempName = PlayerPrefs.GetString("playerName0");

                PlayerPrefs.SetInt("playerScore0", Score.totalScore);
                PlayerPrefs.SetInt("playerScore1", tempScore);

                PlayerPrefs.SetString("playerName0", playerName);
                PlayerPrefs.SetString("playerName1", tempName);

                PlayerPrefs.Save();
            }

            else
            {
                PlayerPrefs.SetInt("playerScore1", Score.totalScore);
                PlayerPrefs.SetString("playerName1", playerName);
                PlayerPrefs.Save();
            }
        }

        else if (!PlayerPrefs.HasKey("playerScore2"))
        {
            if (Score.totalScore > PlayerPrefs.GetInt("playerScore0"))
            {
                int previousHighestScore = PlayerPrefs.GetInt("playerScore0");
                int previousSecondHighestScore = PlayerPrefs.GetInt("playerScore1");

                string previousHighestName = PlayerPrefs.GetString("playerName0");
                string previousSecondHighestName = PlayerPrefs.GetString("playerName1");

                PlayerPrefs.SetInt("playerScore0", Score.totalScore);
                PlayerPrefs.SetInt("playerScore1", previousHighestScore);
                PlayerPrefs.SetInt("playerScore2", previousSecondHighestScore);

                PlayerPrefs.SetString("playerName0", playerName);
                PlayerPrefs.SetString("playerName1", previousHighestName);
                PlayerPrefs.SetString("playerName2", previousSecondHighestName);

                PlayerPrefs.Save();
            }

            else if (Score.totalScore < PlayerPrefs.GetInt("playerScore0") && Score.totalScore > PlayerPrefs.GetInt("playerScore1"))
            {
                int previousSecondHighestScore = PlayerPrefs.GetInt("playerScore1");
                string previousSecondHighestName = PlayerPrefs.GetString("playerName1");

                PlayerPrefs.SetInt("playerScore1", Score.totalScore);
                PlayerPrefs.SetInt("playerScore2", previousSecondHighestScore);

                PlayerPrefs.SetString("playerName1", playerName);
                PlayerPrefs.SetString("playerName2", previousSecondHighestName);

                PlayerPrefs.Save();
            }

            else
            {
                PlayerPrefs.SetInt("playerScore2", Score.totalScore);
                PlayerPrefs.SetString("playerName2", playerName);
                PlayerPrefs.Save();
            }
        }

        else if (PlayerPrefs.HasKey("playerScore2"))
        {
            if (Score.totalScore > PlayerPrefs.GetInt("playerScore0"))
            {
                int previousHighestScore = PlayerPrefs.GetInt("playerScore0");
                int previousSecondHighestScore = PlayerPrefs.GetInt("playerScore1");

                string previousHighestName = PlayerPrefs.GetString("playerName0");
                string previousSecondHighestName = PlayerPrefs.GetString("playerName1");

                PlayerPrefs.SetInt("playerScore0", Score.totalScore);
                PlayerPrefs.SetInt("playerScore1", previousHighestScore);
                PlayerPrefs.SetInt("playerScore2", previousSecondHighestScore);

                PlayerPrefs.SetString("playerName0", playerName);
                PlayerPrefs.SetString("playerName1", previousHighestName);
                PlayerPrefs.SetString("playerName2", previousSecondHighestName);

                PlayerPrefs.Save();
            }

            else if (Score.totalScore < PlayerPrefs.GetInt("playerScore0") && Score.totalScore > PlayerPrefs.GetInt("playerScore1"))
            {
                int previousSecondHighestScore = PlayerPrefs.GetInt("playerScore1");
                string previousSecondHighestName = PlayerPrefs.GetString("playerName1");

                PlayerPrefs.SetInt("playerScore1", Score.totalScore);
                PlayerPrefs.SetInt("playerScore2", previousSecondHighestScore);

                PlayerPrefs.SetString("playerName1", playerName);
                PlayerPrefs.SetString("playerName2", previousSecondHighestName);

                PlayerPrefs.Save();
            }

            else if (Score.totalScore < PlayerPrefs.GetInt("playerScore1") && Score.totalScore > PlayerPrefs.GetInt("playerScore2"))
            {
                PlayerPrefs.SetInt("playerScore2", Score.totalScore);
                PlayerPrefs.SetString("playerName2", playerName);
                PlayerPrefs.Save();
            }
        }
    }


    public void PrintResult()
    {
        scoreText[0].text = Score.totalScore.ToString();
        scoreText[1].text = PlayerPrefs.GetInt("playerScore0").ToString();
        scoreText[2].text = PlayerPrefs.GetInt("playerScore1").ToString();
        scoreText[3].text = PlayerPrefs.GetInt("playerScore2").ToString();

        nameText[0].text = PlayerPrefs.GetString("playerName0");
        nameText[1].text = PlayerPrefs.GetString("playerName1");
        nameText[2].text = PlayerPrefs.GetString("playerName2");
    }
}

