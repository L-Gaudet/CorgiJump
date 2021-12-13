using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformSpawner : MonoBehaviour
{
    public GameObject Platform1Prefab;
    public GameObject Platform2Prefab;
    public GameObject Platform3Prefab;

    private float minimumYDistance = 1f;
    private float maximumYDistance = 3f;
    private int numberOfPlatforms = 50;

    private bool isMoving = false;


    // Update is called once per frame
    void Update()
    {
        if (isMoving)
        {
           
            //MovePlatforms();  // just for testing
            UpdatePlatforms();
        }

    }

    private void MovePlatforms()
    {
        GameObject[] platformObjects = GameObject.FindGameObjectsWithTag("Platform");

        // if a platform is too far off bottom screen
        for (int i = 0; i < platformObjects.Length; i++)
        {
            platformObjects[i].transform.Translate(new Vector3(0f, -0.4f, 0f));
        }
    }

    public void CreateInitialPlatforms()
    {
        isMoving = true;

        float lastPlatformHeight = -4f;
        SpawnPlatform(lastPlatformHeight);

        for (int i = 0; i < numberOfPlatforms; i++)
        {
            lastPlatformHeight = SpawnPlatform(lastPlatformHeight);
        }
    }

    public float SpawnPlatform(float lastPlatformY)
    {
        float randomX = Random.Range(-2.4f, 2.2f);
        float randomY = Random.Range(minimumYDistance, maximumYDistance) + lastPlatformY;

        int randomNumber = Random.Range(0, 100);
        if (randomNumber < 20)
        {
            Instantiate(Platform1Prefab, new Vector3(randomX, randomY, 0f), Quaternion.identity);
        }
        else if (randomNumber < 80)
        {
            Instantiate(Platform2Prefab, new Vector3(randomX, randomY, 0f), Quaternion.identity);
        }
        else
        {
            Instantiate(Platform3Prefab, new Vector3(randomX, randomY, 0f), Quaternion.identity);
        }

        return randomY;
    }

    public void UpdatePlatforms()
    {
        // get all the platforms
        GameObject[] platformObjects = GameObject.FindGameObjectsWithTag("Platform");

        // if a platform is too far off bottom screen
        for (int i = 0; i < platformObjects.Length; i++)
        {
            if (IsTooFarOffScreen(platformObjects[i]))
            {
                DeletePlatform(platformObjects[i]);
                AddNewPlatform(platformObjects);
            }
        }
    }

    private bool IsTooFarOffScreen(GameObject platformObject)
    {
        if (platformObject.transform.position.y < -10f)
            return true;
        return false;
    }

    private void DeletePlatform(GameObject platformObject)
    {
        Destroy(platformObject);
    }

    private void AddNewPlatform(GameObject[] platformObjects)
    {
        print("add new");
        GameObject highestPlatform = GetHighestPlatform(platformObjects);
        SpawnPlatform(highestPlatform.transform.position.y);

    }

    private GameObject GetHighestPlatform(GameObject[] platformObjects)
    {
        GameObject highestPlatform = platformObjects[0];
        foreach (GameObject platformObject in platformObjects)
        {
            if (platformObject.transform.position.y > highestPlatform.transform.position.y)
                highestPlatform = platformObject;
        }

        return highestPlatform;
    }
}
