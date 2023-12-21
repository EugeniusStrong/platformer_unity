using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowActivator : MonoBehaviour
{
    
    private void OnTriggerEnter(Collider other)
    {
        Arrow arrow = other.gameObject.GetComponent<Arrow>();
        if (arrow)
        {
           arrow.ArrowStart();
        }
    }
        
    
}
