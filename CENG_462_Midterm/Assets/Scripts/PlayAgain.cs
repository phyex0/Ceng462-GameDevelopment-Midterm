using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayAgain : MonoBehaviour
{
    public void Restart()
    {
        Score.totalScore = 0;
        PlayerPrefs.SetString("playerName", Score.playerName);
        SceneManager.LoadScene("FirstLevel");
    }

    public void ExitApp()
    {      
        Application.Quit();
    }
}
