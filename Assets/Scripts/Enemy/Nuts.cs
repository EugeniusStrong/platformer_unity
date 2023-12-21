using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nuts : MonoBehaviour
{
    public Vector3 Velocity;
    public float MaxRotationSpeed;

    void Start()
    {
        GetComponent<Rigidbody>().AddRelativeForce(Velocity,ForceMode.VelocityChange);
        GetComponent<Rigidbody>().angularVelocity = new Vector3
            (Random.Range(-MaxRotationSpeed, MaxRotationSpeed),
            Random.Range(-MaxRotationSpeed, MaxRotationSpeed),
            Random.Range(-MaxRotationSpeed, MaxRotationSpeed));
    }

}
