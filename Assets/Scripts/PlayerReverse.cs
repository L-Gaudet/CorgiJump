using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerReverse : MonoBehaviour
{
    public SpriteRenderer CorgiSpriteRenderer;

    public float movementSpeed = -10f;
    private float movement = 0f;

    Rigidbody2D rigidBodyComponent;

    void Start()
    {
        rigidBodyComponent = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        movement = Input.GetAxis("Horizontal") * movementSpeed;
    }

    void FixedUpdate()
    {
        Vector2 velocity = rigidBodyComponent.velocity;
        velocity.x = movement;
        rigidBodyComponent.velocity = velocity;
        checkToFlipCorgiSprite();
    }

    private void checkToFlipCorgiSprite()
    {
        if (movement < 0)
        {
            CorgiSpriteRenderer.flipX = true;
        }
        if (movement > 0)
        {
            CorgiSpriteRenderer.flipX = false;
        }
    }

}
