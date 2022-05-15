using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class StartScreen : MonoBehaviour
{
    [SerializeField] GameObject inputField;
    [SerializeField] GameObject placeHolder;

    private string playerName;

    public void PlayGame()
    {

        playerName = inputField.GetComponent<TMP_InputField>().text;
        Score.playerName = playerName;

        PlayerPrefs.SetString("playerName", playerName);
        PlayerPrefs.Save();

        //user cannot start the game until enter the his/her name
        if (string.IsNullOrEmpty(inputField.GetComponent<TMP_InputField>().text))
        {
            placeHolder.GetComponent<Animator>().enabled = true;
        }
        else
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

        }


    }

    public void ExitGame()
    {
        Application.Quit();
        Debug.Log("Exit succcesfully");
    }
}