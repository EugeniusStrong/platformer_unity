using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    public GameObject DieEffectPrefab;
    public float CoinRotate = 30;

    void Update()
    {
       
        transform.Rotate(0, CoinRotate * Time.deltaTime, 0);
        
    }
    public void Die()
    {
        Instantiate(DieEffectPrefab, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }
}
