using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cloud : MonoBehaviour
{
    public GameObject backgroundCloud;
    public float minimumYDistance = 5f;
    public float maximumYDistance = 10f;
    public int numberOfClouds = 5;

    private bool isMoving = false;


    // Update is called once per frame
    void Update()
    {
        if (isMoving)
        {
            UpdateClouds();
        }

    }

    public void CreateInitialClouds()
    {
        isMoving = true;

        float lastCloudHeight = -4f;
        SpawnCloud(lastCloudHeight);

        for (int i = 0; i < numberOfClouds; i++)
        {
            lastCloudHeight = SpawnCloud(lastCloudHeight);
        }
    }

    public float SpawnCloud(float lastCloudY)
    {
        float randomX = Random.Range(-4f, 4f);
        float randomY = Random.Range(minimumYDistance, maximumYDistance) + lastCloudY;
        float randomZ = Random.Range(0.4f, 7f);


        Instantiate(backgroundCloud, new Vector3(randomX, randomY, randomZ), Quaternion.identity);

        return randomY;
    }

    public void UpdateClouds()
    {
        // get all the clouds
        GameObject[] cloudObjects = GameObject.FindGameObjectsWithTag("Cloud");

        // if a cloud is too far off bottom screen
        for (int i = 0; i < cloudObjects.Length; i++)
        {
            if (IsTooFarOffScreen(cloudObjects[i]))
            {
                DeleteCloud(cloudObjects[i]);
                AddNewCloud(cloudObjects);
            }
        }
    }

    private bool IsTooFarOffScreen(GameObject cloudObject)
    {
        if (cloudObject.transform.position.y < Camera.main.transform.position.y - 13)
            return true;
        return false;
    }

    private void DeleteCloud(GameObject platformObject)
    {
        Destroy(platformObject);
    }

    private void AddNewCloud(GameObject[] platformObjects)
    {
        print("add new cloud");
        GameObject highestPlatform = GetHighestCloud(platformObjects);
        SpawnCloud(highestPlatform.transform.position.y);

    }

    private GameObject GetHighestCloud(GameObject[] cloudObjects)
    {
        GameObject highestCloud = cloudObjects[0];
        foreach (GameObject cloudObject in cloudObjects)
        {
            if (cloudObject.transform.position.y > highestCloud.transform.position.y)
                highestCloud = cloudObject;
        }

        return highestCloud;
    }
}
