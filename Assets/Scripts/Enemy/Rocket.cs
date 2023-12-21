using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rocket : MonoBehaviour
{
    public float Speed = 1;
    public float RotationSpeed = 1;
    public RocketParticle RocketParticle;

    private Transform _playerTransform;

    public ParticleSystem RocketSmoke;

    void Start()
    {
        _playerTransform = FindObjectOfType<PlayerMove>().transform;

        Vector3 toTarget = _playerTransform.position - transform.position;
        transform.rotation = Quaternion.LookRotation(toTarget, Vector3.forward);
        RocketSmoke.Play();
    }

    void Update()
    {
        transform.position += Time.deltaTime * transform.forward * Speed;
        Vector3 toPlayer = _playerTransform.position - transform.position;
        Quaternion targetRotation = Quaternion.LookRotation(toPlayer, Vector3.forward);
        transform.rotation = Quaternion.Lerp(transform.rotation, targetRotation, Time.deltaTime * RotationSpeed);
        
    }
    private void OnDisable()
    {
        RocketParticle.DestroyRocket();
    }
}
