using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BodyRotation : MonoBehaviour
{
    public Transform Head;
    public Transform Target;

    void Update()
    {
        Vector3 HeadLook = Target.position - Head.position;
        Vector3 HeadLookXZ = new Vector3(HeadLook.x, 0, HeadLook.z);
        Head.localRotation = Quaternion.Lerp(Head.localRotation, Quaternion.LookRotation(HeadLookXZ), Time.deltaTime * 8f);
    }
}
