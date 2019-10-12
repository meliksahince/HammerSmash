using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
   public float spawnDelay = 5f;

   public GameObject Zombie;

   public Transform[] spawnPoints;
   float nextTimeToSpawn = 3f;

  // float countDownTimer = 2f;

   void Update ()
   {
      /*if(countDownTimer <= 0f)
      {
          SpawnBlock();
          countDownTimer = 3f;

      }else
      {
          countDownTimer -= Time.deltaTime;
      }*/

     if(nextTimeToSpawn <= Time.time)
     {
         SpawnEnemy();
         nextTimeToSpawn = Time.time + spawnDelay;
     }
   }

   void SpawnEnemy(){

       int randomIndex = Random.Range(0, spawnPoints.Length);
       Transform spawnPoint = spawnPoints[randomIndex];

       Instantiate(Zombie, spawnPoint.position, spawnPoint.rotation);
    }
}
