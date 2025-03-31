using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;
using UnityEngine.SceneManagement;

public class spawnEnemy : MonoBehaviour
{
    public GameObject slime;
    bool canSpawnSlimes = true;
    public TMP_Text text;
    public int slimesKilled = 0;
    void Update()
    {
        if (canSpawnSlimes)
        {
        Vector3 randomSpawnPosition = new Vector3(UnityEngine.Random.Range(-20, 20), UnityEngine.Random.Range(-20, 20), UnityEngine.Random.Range(-20, 20));
        Instantiate(slime, randomSpawnPosition, Quaternion.identity);
        StartCoroutine(startCooldown(0.1f));
        }

        text.text = "Slimes Killed: " + slimesKilled;

        if(slimesKilled >= 100)
        {
            SceneManager.LoadSceneAsync(2);
        }
    }
    IEnumerator startCooldown(float timer)
    {
        canSpawnSlimes = false;
        yield return new WaitForSeconds(timer);
        canSpawnSlimes = true;
    }
}
