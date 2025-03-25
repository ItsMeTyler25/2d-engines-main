using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnEnemy : MonoBehaviour
{
    public GameObject slime;
    private int slimeAmount = 0;
    bool canSpawnSlimes = true;
    private int maxSlimes = 100;
    void Update()
    {
        if (slimeAmount < maxSlimes && canSpawnSlimes)
        {
        slimeAmount += 1;
        Vector3 randomSpawnPosition = new Vector3(Random.Range(-20, 20), Random.Range(-20, 20), Random.Range(-20, 20));
        Instantiate(slime, randomSpawnPosition, Quaternion.identity);
        StartCoroutine(startCooldown(0.1f));
        }
    }
    IEnumerator startCooldown(float timer)
    {
        canSpawnSlimes = false;
        yield return new WaitForSeconds(timer);
        canSpawnSlimes = true;
    }
}
