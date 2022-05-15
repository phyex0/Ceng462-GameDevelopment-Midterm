using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    [SerializeField] private TMPro.TextMeshProUGUI scoreText;
    // Start is called before the first frame update
    void Start()
    {
        scoreText.text = (Score.totalScore).ToString();
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = (Score.totalScore).ToString();
    }
}
