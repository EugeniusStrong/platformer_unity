using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectorCoin : MonoBehaviour
{
    public Score Score;

    private void OnTriggerEnter(Collider other)
    {
        Coin coin = other.gameObject.GetComponent<Coin>();
        if (coin)
        {
            coin.Die();
            Score.AddOne();

        }
        
    }
    
}
