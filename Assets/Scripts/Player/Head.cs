using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Head : MonoBehaviour
{
    public Transform Target;
    void Update()
    {
        transform.position = Target.position;
    }
}
