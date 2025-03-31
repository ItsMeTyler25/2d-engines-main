using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class health : MonoBehaviour
{
    public int maxHealth;
    int currentHealth;
    public GameObject player;

    private void Start()
    {
        currentHealth = maxHealth;
    }

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
        Debug.Log("My <b>current<b> <color = green>HEALTH</color> <b>is<b> " + currentHealth);

        if (currentHealth <= 0)
        {
            Die();
        }

        if (currentHealth <= 1)
        {
            Debug.Log("I'm bouta lock in fr fr");
        }
    }

    void Die()
    {
        Debug.Log("So rude OMG >:/");
        player.GetComponent<spawnEnemy>().slimesKilled += 1;
        Destroy(gameObject);
    }
}
