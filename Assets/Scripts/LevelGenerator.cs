using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelGenerator : MonoBehaviour
{
    public GameObject platform2Prefab;
    public GameObject cloudPrefab;
    public GameObject platform1Prefab;
     

    public int numberOfPlatforms = 200;
    public int numberOfClouds = 75;
    public float levelWidth = 3f;
    public float minY;
    public float maxY;


    // Start is called before the first frame update
    void Start()
    {
        /*
        Vector3 spawnPosition = new Vector3();
        for (int i = 0; i < numberOfPlatforms; i++)
        {
            spawnPosition.y += Random.Range(minY, maxY);
            spawnPosition.x = Random.Range(-levelWidth, levelWidth);
            Instantiate(platform2Prefab, spawnPosition, Quaternion.identity);
            if (i == Random.Range(1,200))
            {
                spawnPosition.y += Random.Range(minY, maxY);
                spawnPosition.x = Random.Range(-levelWidth, levelWidth);
                Instantiate(platform1Prefab, spawnPosition, Quaternion.identity);
            }
        }
        */
    }

    void SpawnPlatform()
    {
        //pick a random number between 1 and 100, make a spring
        //else make a normal one
    }

    void Update()
    {

    }

}
