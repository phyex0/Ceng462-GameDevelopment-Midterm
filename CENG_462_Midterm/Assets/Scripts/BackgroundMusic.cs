using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//this script is for audio that are always play in the background
public class BackgroundMusic : MonoBehaviour
{
    private static BackgroundMusic instance = null;
    public static BackgroundMusic Instance
    {
        get { return instance; }
    }
    void Awake()
    {
        if (instance != null && instance != this) {
            Destroy(this.gameObject);
            return;
        } else
        {
            instance = this;
        }
        DontDestroyOnLoad(this.gameObject);
    }
}
