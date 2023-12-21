using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class liquid : MonoBehaviour
{
    public float PushForce = 20f;
    public float Friction = 0.2f;
    public float JumpSpeed = 0.1f;
    public int HealthValue = 1;
    public AudioSource Bite;

    float timer = 2f;
    private void OnTriggerStay(Collider other)
    {
        other.attachedRigidbody.AddForce(Vector3.up * PushForce);
        other.attachedRigidbody.AddForce(-other.attachedRigidbody.velocity.x * Friction, 0f, 0f, ForceMode.VelocityChange);
        other.attachedRigidbody.AddForce(0, JumpSpeed, 0, ForceMode.VelocityChange);

        PlayerHeath playerHeath = other.attachedRigidbody.GetComponent<PlayerHeath>();
        if (playerHeath != null)
        {
            timer += Time.deltaTime;
            if (timer > 2f)
            {
                timer = 0f;
                playerHeath.TakeDamage(HealthValue);
                Bite.Play();
            }

        }


    }
    
}
