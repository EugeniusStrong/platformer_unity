using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerArmory : MonoBehaviour
{
    public Gun[] Guns;
    public int CurrentGunIndex;
    public AudioSource Reload;
    void Start()
    {
        TakeGunByIndex(CurrentGunIndex);
    }
    public void TakeGunByIndex(int gunIndex)
    {
        for (int i = 0; i < Guns.Length; i++)
        {
            CurrentGunIndex = gunIndex;
            if (i == gunIndex)
            {
                Guns[i].Activate();
            }
            else
            {
                Guns[i].Deactivate();
            }
        }
    }
    public void AddBullets(int gunIndex, int numberOfBullets)
    {
        Guns[gunIndex].AddBullets(numberOfBullets);
        Reload.Play();
    }

}
