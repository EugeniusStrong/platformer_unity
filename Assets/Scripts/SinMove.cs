using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SinMove : MonoBehaviour
{
    
    private void Update()
    {
        transform.localPosition = new Vector3(0, Mathf.Sin(Time.time) * 3f, 0f);
    }


}
