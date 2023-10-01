using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinPickUp : MonoBehaviour
{
    void OnTriggerEnter(Collider col)
    {
        gameObject.SetActive(false);
       // GlobalCoins.CoinCount += 1;
    }
}
