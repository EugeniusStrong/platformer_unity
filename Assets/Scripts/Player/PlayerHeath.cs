using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerHeath : MonoBehaviour
{
    public int Health = 5;
    public int MaxHealth = 8;
    private float _timer;

    private bool _involverable = false;

    public AudioSource AddHealthSound;
    public AudioSource DieSound;

    public HealthUI HealthUI;

    public MonoBehaviour[] ComponentsToDisable;

    public UnityEvent EventOnTakeDamage;

    public Image DieBackground;
    public GameObject DieText;



    private void Start()
    {
        HealthUI.Setup(MaxHealth);
        HealthUI.DisplayHealth(Health);
    }
    public void TakeDamage(int damageValue)
    {
        if(_involverable == false)
        {
            Health -= damageValue;
            if (Health <= 0)
            {
                Health = 0;
                Die();
            }
            _involverable = true;
            Invoke("StopInvolverable", 1f);
            HealthUI.DisplayHealth(Health);

            EventOnTakeDamage.Invoke();
        }
        
    }
    void StopInvolverable()
    {
        _involverable = false;
    }
    public void AddHealth(int healthValue)
    {
        Health += healthValue;
        if(Health > MaxHealth)
        {
            Health = MaxHealth;
        }
        AddHealthSound.Play();
        HealthUI.DisplayHealth(Health);
    }
    public void Die()
    {
        
        for (int i = 0; i < ComponentsToDisable.Length; i++)
        {
            ComponentsToDisable[i].enabled = false;

        }
        Time.timeScale = 0.01f;
        Cursor.visible = true;
        GameObject.FindWithTag("Finish").SetActive(false);
        GameObject.FindWithTag("GameController").SetActive(false);
        DieSound.Play();
        DieText.SetActive(true);
        DieBackground.color = Color.Lerp(DieBackground.color, new Color(0f, 0f, 0f, 255f), Time.deltaTime * 0.15f);
        
    }
    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        
    }


}
