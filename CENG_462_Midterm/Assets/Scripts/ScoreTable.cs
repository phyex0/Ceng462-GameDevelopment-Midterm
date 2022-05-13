using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//This script is for saving and show last 5 scores and player names
//For saving data I used PlayerPerfs
public class ScoreTable : MonoBehaviour
{

    [SerializeField] private TMPro.TextMeshProUGUI[] nameText;
    [SerializeField] private TMPro.TextMeshProUGUI[] scoreText;

    private void Start()
    {
        Result();
        PrintResult();
    }

    public void Result()
    {
        PlayerScores();
        PlayerNames();
        //PlayerPrefs.DeleteAll();
    }

    private static void PlayerScores()
    {
        PlayerPrefs.SetInt("playerScore", Score.totalScore);
        PlayerPrefs.Save();



        if (!PlayerPrefs.HasKey("playerScore0"))
        {
            PlayerPrefs.SetInt("playerScore0", Score.totalScore);
            PlayerPrefs.Save();
        }

        else if (!PlayerPrefs.HasKey("playerScore1"))
        {
            PlayerPrefs.SetInt("playerScore1", Score.totalScore);
            PlayerPrefs.Save();
        }

        else if (!PlayerPrefs.HasKey("playerScore2"))
        {
            PlayerPrefs.SetInt("playerScore2", Score.totalScore);
            PlayerPrefs.Save();
        }

        else if (!PlayerPrefs.HasKey("playerScore3"))
        {
            PlayerPrefs.SetInt("playerScore3", Score.totalScore);
            PlayerPrefs.Save();
        }

        else if (!PlayerPrefs.HasKey("playerScore4"))
        {
            PlayerPrefs.SetInt("playerScore4", Score.totalScore);
            PlayerPrefs.Save();
        }

        else if (PlayerPrefs.HasKey("playerScore4"))
        {
            PlayerPrefs.SetInt("playerScore0", PlayerPrefs.GetInt("playerScore1"));
            PlayerPrefs.SetInt("playerScore1", PlayerPrefs.GetInt("playerScore2"));
            PlayerPrefs.SetInt("playerScore2", PlayerPrefs.GetInt("playerScore3"));
            PlayerPrefs.SetInt("playerScore3", PlayerPrefs.GetInt("playerScore4"));
            PlayerPrefs.SetInt("playerScore4", PlayerPrefs.GetInt("playerScore"));
        }
    }

    private void PlayerNames()
    {
        var playerName = PlayerPrefs.GetString("playerName");
        PlayerPrefs.Save();


        if (!PlayerPrefs.HasKey("playerName0"))
        {
            PlayerPrefs.SetString("playerName0", playerName);
            PlayerPrefs.Save();
        }

        else if (!PlayerPrefs.HasKey("playerName1"))
        {
            PlayerPrefs.SetString("playerName1", playerName);
            PlayerPrefs.Save();
        }

        else if (!PlayerPrefs.HasKey("playerName2"))
        {
            PlayerPrefs.SetString("playerName2", playerName);
            PlayerPrefs.Save();
        }

        else if (!PlayerPrefs.HasKey("playerName3"))
        {
            PlayerPrefs.SetString("playerName3", playerName);
            PlayerPrefs.Save();
        }

        else if (!PlayerPrefs.HasKey("playerName4"))
        {
            PlayerPrefs.SetString("playerName4", playerName);
            PlayerPrefs.Save();
        }
        else if (PlayerPrefs.HasKey("playerName4"))
        {
            PlayerPrefs.SetString("playerName0", PlayerPrefs.GetString("playerName1"));
            PlayerPrefs.SetString("playerName1", PlayerPrefs.GetString("playerName2"));
            PlayerPrefs.SetString("playerName2", PlayerPrefs.GetString("playerName3"));
            PlayerPrefs.SetString("playerName3", PlayerPrefs.GetString("playerName4"));
            PlayerPrefs.SetString("playerName4", PlayerPrefs.GetString("playerName"));
        }
    }

    public void PrintResult()
    {
        scoreText[0].text = Score.totalScore.ToString();
        scoreText[1].text = PlayerPrefs.GetInt("playerScore0").ToString();
        scoreText[2].text = PlayerPrefs.GetInt("playerScore1").ToString();
        scoreText[3].text = PlayerPrefs.GetInt("playerScore2").ToString();
        scoreText[4].text = PlayerPrefs.GetInt("playerScore3").ToString();
        scoreText[5].text = PlayerPrefs.GetInt("playerScore4").ToString();


        nameText[0].text = PlayerPrefs.GetString("playerName0");
        nameText[1].text = PlayerPrefs.GetString("playerName1");
        nameText[2].text = PlayerPrefs.GetString("playerName2");
        nameText[3].text = PlayerPrefs.GetString("playerName3");
        nameText[4].text = PlayerPrefs.GetString("playerName4");

    }
}
