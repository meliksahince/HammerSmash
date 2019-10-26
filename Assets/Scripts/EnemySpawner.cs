using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public float spawnrate = 1f;

    public GameObject Zombie;

    public Transform[] spawnPoints;
    float nextTimeToSpawn = 3f;

    float countDownTimer = 2f;

    void FixedUpdate()
    {
        if (countDownTimer <= 0f)
        {
            SpawnEnemy();
            countDownTimer = 4f;
            spawnrate += .03f;
            Debug.Log(spawnrate);

        }
        else
        {
            countDownTimer -= Time.deltaTime * spawnrate;
        }

        /*if(nextTimeToSpawn <= Time.time)
        {
            SpawnEnemy();
            nextTimeToSpawn = Time.time*2.5f + spawnDelay;
        }*/
    }

    void SpawnEnemy()
    {

        int randomIndex = Random.Range(0, spawnPoints.Length);
        Transform spawnPoint = spawnPoints[randomIndex];

        Instantiate(Zombie, spawnPoint.position, spawnPoint.rotation);
        spawnPoints[1].rotation.SetEulerRotation(0, 180, 0);
    }


}
