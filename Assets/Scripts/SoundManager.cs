using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public AudioSource Music;
    public AudioSource TimeSound;


    private void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            Music.Pause();
            TimeSound.Play();
        }
        if (Input.GetMouseButtonUp(1))
        {
            Music.Play();
            TimeSound.Pause();
        }
        
    }

    public void SetMusicEnabled(bool value)
    {
        if (value)
        {
            Music.UnPause();
        }
        else
        {
            Music.Pause();
        }

    }
    public void SetVolume(float value)
    {
        AudioListener.volume = value;
    }
}
