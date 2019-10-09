using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{

    [SerializeField] GameObject spawnerPrefab;
    float spawnerIndex = -0.9f;


    // Start is called before the first frame update
    void Start()
    {
        //for(int i = 0; i < 5; i++)
        //{
        MakeNewSpawnPoint();
        //}
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void MakeNewSpawnPoint(){
      //Vector2 newPosition = new Vector2(1, spawnerIndex * 10);
      Vector2 newPosition = new Vector2(1.5f, spawnerIndex);

      GameObject newSpawnPoint = Instantiate(spawnerPrefab, newPosition, Quaternion.identity);
      newSpawnPoint.transform.SetParent(transform);
      newSpawnPoint.transform.localScale = new Vector2(0.5f, 1);

      //spawnerIndex++;
      

    }
}
