using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class ScoreManager : MonoBehaviour
{
    public TextMeshProUGUI coinstext;
    public static int coinvalue;


    public void Start()
    {
        coinvalue = 0;
    }
    public void Update()
    {
        coinstext.text = "coin:" + coinvalue;
    }
}
