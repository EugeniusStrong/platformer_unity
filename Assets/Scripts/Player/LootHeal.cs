using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LootHeal : MonoBehaviour
{
    public int Healthvalue = 1;
    private void OnTriggerEnter(Collider other)
    {
        if (other.attachedRigidbody.GetComponent<PlayerHeath>())
        {
            other.attachedRigidbody.GetComponent<PlayerHeath>().AddHealth(Healthvalue);
            Destroy(gameObject);
        }
    }
}
