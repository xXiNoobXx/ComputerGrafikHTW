using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using TMPro;

public class GobalCoins : MonoBehaviour
{
    public TextMeshProUGUI CoinDisplay;
    public static int CoinCount;
    private int InternalCoin;

    private void Update()
    {
        InternalCoin = CoinCount;
      //  CoinDisplay.text = "Coins: " + CoinCount;
    }
}
