using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinalLevelScript : MonoBehaviour
{
    private void Update()
    {
        if (Health.playerHealth == 0)
        {
            SceneManager.LoadScene("GameOver");
        }

        else if (Health.bossHealth == 0)
        {
            SceneManager.LoadScene("Win");
        }
    }
}
