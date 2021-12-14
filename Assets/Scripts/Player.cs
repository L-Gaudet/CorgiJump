using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Rigidbody2D))]
public class Player : MonoBehaviour
{
    public SpriteRenderer CorgiSpriteRenderer;

    public float movementSpeed = 10f;
    private float movement = 0f;
    public float topScore = 0.0f;

    Rigidbody2D rigidBodyComponent;

    public Text scoreText;

    void Start()
    {
        rigidBodyComponent = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        movement = Input.GetAxis("Horizontal") * movementSpeed;
        if (rigidBodyComponent.velocity.y > 0 && transform.position.y > topScore)
        {
            topScore = transform.position.y;
        }
        scoreText.text = "Score: " + (Mathf.Round((topScore*2))).ToString();
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
