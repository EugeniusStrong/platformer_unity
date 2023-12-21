using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    public GameObject BulletPrefab;
    public Transform Spawn;
    public float BulletSpeed = 10f;
    public float ShotPeriod = 0.08f;
    public AudioSource ShotSound;
    public GameObject ShotFlash;

    private float _timer;

    public ParticleSystem ShotEffect;


    void Update()
    {

        ShotSound.pitch = Time.timeScale;

        _timer += Time.deltaTime;
        if(_timer > ShotPeriod)
        {
            if (Input.GetMouseButton(0) )
            {
                _timer = 0f;
                Shot();
               
            }
        }


    }
    public virtual void Shot()
    {
        GameObject newBullet = Instantiate(BulletPrefab, Spawn.position, Spawn.rotation);
        newBullet.GetComponent<Rigidbody>().velocity = Spawn.forward * BulletSpeed;
        ShotSound.Play();
        ShotFlash.SetActive(true);

        Invoke("HideFlash", 0.08f);
        ShotEffect.Play();
    }
    public void HideFlash()
    {
        ShotFlash.SetActive(false);
    }
    public virtual void Activate()
    {
        gameObject.SetActive(true);
    }
    public virtual void Deactivate()
    {
        gameObject.SetActive(false);
    }
    public virtual void AddBullets(int numberOfBullets)
    {

    }
}

