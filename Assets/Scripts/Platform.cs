using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour
{
    public float jumpForce = 10f;

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.relativeVelocity.y <= 0f)
        {
            Rigidbody2D rigidbody = collision.collider.GetComponent<Rigidbody2D>();
            if (rigidbody != null)
            {
                Vector2 velocity = rigidbody.velocity;
                velocity.y = jumpForce;
                rigidbody.velocity = velocity;
            }
        }
    }

    void Update()
    {
        Vector2 screenPosition = Camera.main.WorldToScreenPoint(transform.position);
        if (screenPosition.y < -50)
            Destroy(gameObject);
    }
}
