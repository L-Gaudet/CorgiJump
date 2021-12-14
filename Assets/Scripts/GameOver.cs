using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float newYPostion = Camera.main.transform.position.y + 1;

        transform.position = new Vector3(transform.position.x, newYPostion , transform.position.z);
    }
}
