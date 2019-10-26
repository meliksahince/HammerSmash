using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyEnemySpawner : MonoBehaviour
{
    public float spawnDelay = 5f;

    public GameObject Alien;

    public Transform[] spawnPoints;
    float nextTimeToSpawn = 3f;

    // float countDownTimer = 2f;

    void Update()
    {
        /*if(countDownTimer <= 0f)
        {
            SpawnBlock();
            countDownTimer = 3f;

        }else
        {
            countDownTimer -= Time.deltaTime;
        }*/

        if (nextTimeToSpawn <= Time.time)
        {
            SpawnEnemy();
            nextTimeToSpawn = Time.time + spawnDelay;
        }
    }

    void SpawnEnemy()
    {

        int randomIndex = Random.Range(0, spawnPoints.Length);
        Transform spawnPoint = spawnPoints[randomIndex];

        Instantiate(Alien, spawnPoint.position, spawnPoint.rotation);
    }
}
