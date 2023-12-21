using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RocketParticle : MonoBehaviour
{
    public ParticleSystem Particle;
    public void DestroyRocket()
    {
        transform.parent = null;
        Particle.Stop();
        Destroy(gameObject, 5f);
    }
}
