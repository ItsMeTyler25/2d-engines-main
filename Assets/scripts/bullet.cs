using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine;

public class bullet : MonoBehaviour
{
    public int damage = 5;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Enemy"))
        {
            collision.GetComponent<health>().TakeDamage(damage);
        }

        Destroy(gameObject);
    }
}
