using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    public static int bossHealth = 100;
    public static int playerHealth = 100;

    [SerializeField] Image playerHealthBar;
    [SerializeField] Image bossHealthBar;

    private void Start()
    {
        playerHealthBar.fillAmount = 1.0f;
        bossHealthBar.fillAmount = 1.0f;
    }


    private void Update()
    {
        playerHealthBar.fillAmount = playerHealth / 100.0f;
        bossHealthBar.fillAmount = bossHealth / 100.0f;

        HealthBarColor(playerHealthBar, playerHealth / 100.0f);
        HealthBarColor(bossHealthBar, bossHealth / 100.0f);

    }


    private void HealthBarColor(Image HealthBar, float value)
    {
        if(value < 0.3)
        {
            HealthBar.color = Color.red;
        }
        else if (value < 0.6)
        {
            HealthBar.color = Color.yellow;
        }
        else
        {
            HealthBar.color = Color.green;
        }
    }




}
