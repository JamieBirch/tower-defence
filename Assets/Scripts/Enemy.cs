using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float startSpeed = 10f;
    [HideInInspector]
    public float speed;
    public float health = 100;
    public int reward = 50;

    void Start()
    {
        speed = startSpeed;
    }

    public void TakeDamage (float amount)
    {
        health -= amount;

        if (health <= 0)
        {
            Die();
        }
    }

    void Die ()
    {
        PlayerStats.Money += reward;
        Destroy(gameObject);
    }

    public void Slow(float slowPct)
    {
        speed = startSpeed * (1f - slowPct);
    }
}
