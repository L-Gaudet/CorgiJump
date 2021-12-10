using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Camera Camera;
    public Transform target;
    public float smoothSpeed = 0.3f;
    public MainMenu MainMenu;

    private Vector3 currentVelocity;

    void LateUpdate()
    {
       //  Camera.main.
        if (target.position.y > Camera.transform.position.y)
        {
            Vector3 newPosition = new Vector3(transform.position.x, target.position.y, Camera.transform.position.z);
            Camera.transform.position = Vector3.SmoothDamp(Camera.transform.position, newPosition,
                ref currentVelocity, smoothSpeed * Time.deltaTime);
        }

        if (target.position.y < transform.position.y - 5)
        {
            MainMenu.GameOver();
        }
    }
}
