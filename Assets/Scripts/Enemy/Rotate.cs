using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    public Vector3 RotationSpeed;

    void Update()
    {
        transform.Rotate(RotationSpeed * Time.deltaTime);
    }
}
