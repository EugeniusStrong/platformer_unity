using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BatchPrefabCreator : MonoBehaviour
{
    public GameObject Prefab;
    public Transform[] Spawns;

    [ContextMenu("Create")]
    public void Create()
    {
        for (int i = 0; i < Spawns.Length; i++)
        {
            Instantiate(Prefab, Spawns[i].position, Spawns[i].rotation);
        }
    }
}
