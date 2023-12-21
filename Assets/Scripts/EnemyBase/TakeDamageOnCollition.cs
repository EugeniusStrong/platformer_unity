using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TakeDamageOnCollition : MonoBehaviour
{

    public EnemyHealth EnemyHealth;
    public bool DieOnAnyCollition;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.rigidbody)
        {
            if (collision.rigidbody.GetComponent<Bullet>())
            {
                EnemyHealth.TakeDamage(1);
            }
        }
        if(DieOnAnyCollition == true)
        {
            EnemyHealth.TakeDamage(1000);
        }
        
    }
}
