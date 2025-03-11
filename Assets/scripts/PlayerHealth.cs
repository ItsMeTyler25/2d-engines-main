using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public float maxHealth;
    public float currentHealth;
    public HUDManager HUD;
    public gameOver gameOverScript;

    void Start()
    {
        Time.timeScale = 1f;
        currentHealth = maxHealth;
        HUD.UpdateHealthBar(currentHealth / maxHealth);
    }

    public void TakeDamage(float damageAmount)
    {
        currentHealth -= damageAmount;
        HUD.UpdateHealthBar(currentHealth/maxHealth);
    }

    void Update()
    {
        if (currentHealth <= 0)
        Die();
    }

    public void Die()
    {
        gameOverScript.EndGame();
    }
}
