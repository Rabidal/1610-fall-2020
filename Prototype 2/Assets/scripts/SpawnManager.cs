using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    private float _spawnRangeX = 20;
    private float _spawnPosZ = 20;
    private float _spawnInterval = 1.5f;
    private float _startDelay = 2;
    // Start is called before the first frame update
    void Start() => InvokeRepeating(nameof(SpawnRandomAnimal), _startDelay, _spawnInterval);

    // Update is called once per frame
    void Update()
    {
        {
            int animalIndex = Random.Range(0, animalPrefabs.Length);
            Vector3 spawnPos = new Vector3(Random.Range(-_spawnRangeX,_spawnRangeX), 0, _spawnPosZ);
            Instantiate(animalPrefabs[animalIndex],spawnPos,
                animalPrefabs[animalIndex].transform.rotation);
        }

    }

    void SpawnRandomAnimal()
    {
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        Vector3 spawnPos = new Vector3(Random.Range(-_spawnRangeX, _spawnRangeX), 0, _spawnPosZ);
        Instantiate(animalPrefabs[animalIndex], spawnPos,
            animalPrefabs[animalIndex].transform.rotation);
    }
}
    
