using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DisplayNameAndScore : MonoBehaviour
{

    [SerializeField] private TextMeshProUGUI text;

    private void Start()
    {
        text.text = Score.playerName;
    }
}
