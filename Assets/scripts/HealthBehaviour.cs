using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class HealthBehaviour : MonoBehaviour
{
    public int maxHealth;
    [SerializeField]
    private int currentHealth;


    public event Action OnDie = delegate { };
    public event Action<int> OnHealthChange = delegate { };
    private void Awake()
    {
        currentHealth = maxHealth;
    }

    private void Start()
    {
        OnHealthChange.Invoke(currentHealth);
    }
    public void heal()
    {
        currentHealth = maxHealth;
        OnHealthChange.Invoke(currentHealth);

    }

    public void heal(int health)
    {
        currentHealth = Mathf.Min(maxHealth, currentHealth + health);
        OnHealthChange.Invoke(currentHealth);

    }

    public void TakeDamage(int amount)
    {
        currentHealth = Mathf.Clamp(currentHealth - amount, 0, maxHealth);
        OnHealthChange.Invoke(currentHealth);
        if (currentHealth <= 0) 
        {
            Die();
        }
    }

    public void Die()
    {
        OnDie.Invoke();
    }

}
