using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Enemy : MonoBehaviour
{
    public float startSpeed = 10f;
    [HideInInspector]
    public float speed;
    public float startHealth = 100;
    private float currentHealth;
    public int reward = 50;

    [Header("Unity Stuff")]
    public Image healthBar;

    void Start()
    {
        speed = startSpeed;
        currentHealth = startHealth;
    }

    public void TakeDamage (float amount)
    {
        currentHealth -= amount;

        healthBar.fillAmount = currentHealth / startHealth;

        if (currentHealth <= 0)
        {
            Die();
        }
    }

    void Die ()
    {
        PlayerStats.Money += reward;
        Destroy(gameObject);

        WaveSpawner.EnemiesAlive--;
    }

    public void Slow(float slowPct)
    {
        speed = startSpeed * (1f - slowPct);
    }
}
