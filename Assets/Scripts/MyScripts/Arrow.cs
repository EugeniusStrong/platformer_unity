using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrow : MonoBehaviour
{

    public GameObject ArrowTransform;

    private void Start()
    {
        ArrowTransform.SetActive(false);
    }

    public void ArrowStart()
    {
        ArrowTransform.SetActive(true);


    }
}
