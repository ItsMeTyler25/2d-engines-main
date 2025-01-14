using UnityEngine;
using System.Collections;

public class ExplodeStar : MonoBehaviour
{
    public CameraShake cameraShake;

        void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.CompareTag("Wall"))
        {
        StartCoroutine(cameraShake.Shake(0.15f, 0.10f));
        }
    }
} 