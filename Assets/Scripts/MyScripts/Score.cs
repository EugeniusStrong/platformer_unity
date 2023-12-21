using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public int Coins;
    public Text CoinsText;

    public void AddOne()
    {
        Coins += 1;
        CoinsText.text = Coins.ToString();
    }
}
