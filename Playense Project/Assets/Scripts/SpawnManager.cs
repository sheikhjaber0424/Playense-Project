using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject spawn;
    public GameObject diamondspawn;
    
    private float spawnRangeX = 3;
    private float spawnPosZ = 20;
    private float waitTimer = 0.0f;
    int randomNum;

    bool isSpawn = true;

    // Start is called before the first frame update
    void Start()
    {
       
    }

    void Update()
    {
        waitTimer += Time.deltaTime;
       
            if (isSpawn && GameManager.Instance.isGameActive)
            {
                isSpawn = false;
                SpawnObject();
                StartCoroutine(Delay());
            }
       
        
           
    }

    void SpawnObject()
    {
        randomNum = Random.Range(0, 10);     //ekhane animalPrefabs.lengths=3, kintu ekhane 0-2 range er number generate hobe;
         Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);
        if(randomNum <2)
        {
            Instantiate(diamondspawn, spawnPos, spawn.transform.rotation);
        }
        else
        {
            Instantiate(spawn, spawnPos, spawn.transform.rotation);
        }
        
        //je object ta prefab hishe use korsi shetar rotation tai ekhane count hoy

    }
    IEnumerator Delay()
    {
        if(waitTimer > 20)
        {
            yield return new WaitForSeconds(0.7f);
        }
        else
        {
            yield return new WaitForSeconds(2);
        }
       
        isSpawn = true;
    }

}
