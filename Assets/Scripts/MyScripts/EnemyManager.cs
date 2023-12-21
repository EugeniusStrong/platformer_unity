using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class EnemyManager : MonoBehaviour
{
    public List<EnemyHealth> EnemyList = new List<EnemyHealth>();
    public void RemoveEnemy(EnemyHealth enemyHealth)
    {
        EnemyList.Remove(enemyHealth);
    }

    public EnemyHealth GetClosest(Vector3 point)
    {
        float minDistance = 35f;
        EnemyHealth closestEnemy = null;
        for (int i = 0; i < EnemyList.Count; i++)
        {
            float distance = Vector3.Distance(point, EnemyList[i].transform.position);
            if (distance < minDistance)
            {
                minDistance = distance;

                closestEnemy = EnemyList[i];

                EnemyList[i].gameObject.SetActive(true);
                
            }
            
        }
        return closestEnemy;
        
    }
}
