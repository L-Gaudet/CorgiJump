using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class Player : MonoBehaviour
{
    public SpriteRenderer CorgiSpriteRenderer;

    public float movementSpeed = 10f;
    private float movement = 0f;

    Rigidbody2D rigidbody;

    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        movement = Input.GetAxis("Horizontal") * movementSpeed;

        if (Input.GetKey(KeyCode.A))
        {
            Move(rigidbody.velocity);
        }

        if (Input.GetKey(KeyCode.D))
        {
            Move(rigidbody.velocity);
        }
    }

    /*void FixedUpdate()
    {
        Vector2 velocity = rigidbody.velocity;
        velocity.x = movement;
        rigidbody.velocity = velocity;
    }*/

    private void Move(Vector2 direction)
    {
        CorgiSpriteRenderer.transform.Translate(direction);
    }

}
