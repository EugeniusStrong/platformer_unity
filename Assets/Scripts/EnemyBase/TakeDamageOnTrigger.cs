using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TakeDamageOnTrigger : MonoBehaviour
{
    public EnemyHealth EnemyHealth;
    public bool DieOnAnyCollition;

    private void OnTriggerEnter(Collider other)
    {
       
        if (other.attachedRigidbody)
        {
            Bullet bullet = other.attachedRigidbody.GetComponent<Bullet>();
            if (bullet)
            {
                EnemyHealth.TakeDamage(1);
                bullet.Die();
            }
        }
        if (DieOnAnyCollition == true)
        {
            if(other.isTrigger == false)
            {
                EnemyHealth.TakeDamage(1000);
            }
            
        }
    }
  
}
