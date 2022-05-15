using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public float TimeVal = 20;
    private bool isFinished = false;

    public Text TimeText;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(TimeVal>0)
        {
            TimeVal -= Time.deltaTime;
        }

        else if(TimeVal>0 && isFinished == true)
        {
        TimeText.color = Color.green;
        }
        else if(TimeVal<0 && isFinished == false)
        {
        TimeVal=0;
        TimeText.color = Color.red;
        }
        TimeText.text = ((int)TimeVal).ToString();
    }
}
