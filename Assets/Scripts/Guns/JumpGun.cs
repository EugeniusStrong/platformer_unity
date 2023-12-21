using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpGun : MonoBehaviour
{
    public Rigidbody PlayerRigidbody;
    public float Speed;
    public Transform Spawn;
    public Gun Pistol;
    public float MaxCharge = 3f;
    private float _currentCharge;
    private bool _isCharged;

    public ChargeIcon ChargeIcon;

    private void Update()
    {
       
        if (_isCharged)
        {
            if (Input.GetKeyDown(KeyCode.LeftShift))
            {
                PlayerRigidbody.AddForce(-Spawn.forward * Speed, ForceMode.VelocityChange);
                Pistol.Shot();
                _isCharged = false;
                _currentCharge = 0f;
                ChargeIcon.StartCharge();
            }
        }
        else
        {
            _currentCharge += Time.unscaledDeltaTime;
            ChargeIcon.SetChargeValue(_currentCharge,MaxCharge);
            if (_currentCharge >= MaxCharge)
            {
                _isCharged = true;
                ChargeIcon.StopCharge();
            }
        }
        
    }
}
