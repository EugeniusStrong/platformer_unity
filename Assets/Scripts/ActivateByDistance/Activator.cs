using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Activator : MonoBehaviour
{

    public List<ActivateByDistance> ObjectsToActivate = new List<ActivateByDistance>();
    public Transform PlayerTransform;

    void Update()
    {
        for (int i = 0; i < ObjectsToActivate.Count; i++)
        {
            ObjectsToActivate[i].CheckDistance(PlayerTransform.position);
        }
    }
}
