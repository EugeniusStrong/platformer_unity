using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPointer : MonoBehaviour
{
    public EnemyManager EnemyManager;

    public EnemyHealth ClosestEnemy;


    void Update()
    {
        ClosestEnemy = EnemyManager.GetClosest(transform.position);
    }
}
