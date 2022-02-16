using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject spawn;
    private float spawnRangeX = 3;
    private float spawnPosZ = 20;

    bool isSpawn = true;

    // Start is called before the first frame update
    void Start()
    {
       
    }

    void Update()
    {
        if(isSpawn)
        {
            isSpawn = false;
            SpawnObject();
            StartCoroutine(Delay());
           
        }
        
           
    }

    void SpawnObject()
    {
       
        //ekhane animalPrefabs.lengths=3, kintu ekhane 0-2 range er number generate hobe
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);
        Instantiate(spawn, spawnPos, spawn.transform.rotation);
        //je object ta prefab hishe use korsi shetar rotation tai ekhane count hoy

    }
    IEnumerator Delay()
    {
        yield return new WaitForSeconds(2);
        isSpawn = true;
    }

}
