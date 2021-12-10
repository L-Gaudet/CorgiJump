using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelGenerator : MonoBehaviour
{
    public GameObject platformPrefab;
    public GameObject cloudPrefab;
    private Transform toFollow;

    public int numberOfPlatforms = 200;
    public int numberOfClouds = 75;
    public float levelWidth = 3f;
    public float minY;
    public float maxY;
    private bool canFollow;


    // Start is called before the first frame update
    void Start()
    {
        Vector3 spawnPosition = new Vector3();

        for (int i = 0; i < numberOfPlatforms; i++)
        {
            spawnPosition.y += Random.Range(minY, maxY);
            spawnPosition.x = Random.Range(-levelWidth, levelWidth);
            Instantiate(platformPrefab, spawnPosition, Quaternion.identity);

        }
        canFollow = true;

    }



    void Update()
    {

    }

}
