using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakeDamageOnTrigger : MonoBehaviour
{
    public int DamageValue = 1;

    private void OnTriggerEnter(Collider other)
    {
        if (other.attachedRigidbody)
        {
            if (other.attachedRigidbody.GetComponent<PlayerHeath>())
            {
                other.attachedRigidbody.GetComponent<PlayerHeath>().TakeDamage(DamageValue);
            }
        }
    }
    
}
