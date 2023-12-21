using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakeDamageOnCollition : MonoBehaviour
{
    public int DamageValue = 1;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.rigidbody)
        {
            if (collision.rigidbody.GetComponent<PlayerHeath>())
            {
                collision.rigidbody.GetComponent<PlayerHeath>().TakeDamage(DamageValue);
            }
        }
        
    }

}
