using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ascelations : MonoBehaviour
{

    public float Speed;
    public float Amplitude;
    
    void Update()
    {
        transform.localPosition = new Vector3(Mathf.Sin(Time.time * Speed) * Amplitude, 0, 0);
    }
}
