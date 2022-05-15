using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinalLevelScript : MonoBehaviour
{
    [SerializeField] private TMPro.TextMeshProUGUI scoreText;

    private void Start()
    {
        scoreText.text = (Score.totalScore).ToString();
    }

    private void Update()
    {
        scoreText.text = (Score.totalScore).ToString();


        if (Health.playerHealth <= 0)
        {
            SceneManager.LoadScene("GameOver");
        }

        if (Health.bossHealth <= 0)
        {
            SceneManager.LoadScene("Win");
        }
    }
}
