using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateThis : MonoBehaviour
{
    public float HorizontalRotate;
    public float VerticalRotate;

    void Update()
    {
        transform.Rotate(0, HorizontalRotate * Time.deltaTime, VerticalRotate * Time.deltaTime);
    }
}
