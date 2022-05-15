using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayAgain : MonoBehaviour
{
    public void Restart()
    {
        Score.totalScore = 0;
        Health.playerHealth = 100;
        Health.bossHealth = 100;
        PlayerPrefs.SetString("playerName", Score.playerName);
        SceneManager.LoadScene("FirstLevel");
    }

    public void ExitApp()
    {
        #if UNITY_EDITOR
                EditorApplication.ExitPlaymode();
        #else
            Application.Quit(); // original code to quit Unity player
        #endif
    }
}
