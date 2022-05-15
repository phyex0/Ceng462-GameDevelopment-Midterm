using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{

    [SerializeField] private TMPro.TextMeshProUGUI scoreText;
    [SerializeField] private Text timeText;

    private GameObject[] redVirus;
    private GameObject[] blueVirus;
    // Start is called before the first frame update
    void Start()
    {
        scoreText.text = (Score.totalScore).ToString();
    }

    // Update is called once per frame
    void Update()
    {

        redVirus = GameObject.FindGameObjectsWithTag("Red Virus");
        blueVirus = GameObject.FindGameObjectsWithTag("Blue Virus");

        scoreText.text = (Score.totalScore).ToString();

        if(String.Compare(timeText.text, "0") == 0)
        {
            SceneManager.LoadScene("GameOver");
        }


        if ((redVirus.Length == 0 && blueVirus.Length == 0) && SceneManager.GetActiveScene().name != "FinalLevel")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        } 
    }
}
