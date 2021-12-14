using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatform : MonoBehaviour
{
    private bool moveRight = true;
    public float maxX;
    public float moveSpeed;

    void FixedUpdate()
    {
        if (transform.position.x > maxX)
            moveRight = false;
        if (transform.position.x < -maxX)
            moveRight = true;

        if (moveRight)
            transform.position = new Vector2(transform.position.x + moveSpeed + Time.deltaTime, transform.position.y);
        else
            transform.position = new Vector2(transform.position.x - moveSpeed + Time.deltaTime, transform.position.y);
    }
}
