using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{

    public GameObject[ ] animalPrefabs;
    private float SpawnRangeX = 20;
    private float SpawnPosZ = 20;
    private float StartDelay = 2;
    private float spawnInterval = 1.5f;
    
    // Start is called before the first frame update
    void Start()
    {
       InvokeRepeating("SpawnRandomAnimal", StartDelay, spawnInterval); 
    }

    // Update is called once per frame
    void Update()
    {
        
        
    }

    void SpawnRandomAnimal(){
        Vector3 spawnPos = new Vector3(Random.Range(-SpawnRangeX, SpawnRangeX), 0, SpawnPosZ);

            int animalIndex = Random.Range(0, animalPrefabs.Length);
            Instantiate(animalPrefabs[animalIndex], spawnPos,
            animalPrefabs[animalIndex].transform.rotation);
    }
}
