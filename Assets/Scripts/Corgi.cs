using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/* TO DO:
    - move left or right with arrow keys
    - gravity only affects y velocity 

*/


public class Corgi : MonoBehaviour
{
    public SpriteRenderer CorgiSpriteRenderer;
    public SpriteTools SpriteTools;

    private float initialYVelocity = GameParameters.InitialYVelocity;

    public bool IsCorgiBelowMidScreen = true;

    public void Update()
    {
        ApplyGravity(CorgiSpriteRenderer);
    }


    public void Move(Vector2 direction)
    {
        Vector2 amountToMove = CalculateAmountToMoveX(direction);
        CorgiSpriteRenderer.transform.Translate(amountToMove);

    }

    public void MoveWithKeyboard(Vector2 direction)
    {
        Move(direction);
    }

    private Vector2 CalculateAmountToMoveX(Vector2 direction)
    {
        float amountX = GameParameters.CorgiMoveDistanceX * direction.x;

        return new Vector2(amountX, 0);
    }

    private bool IsCorgiMoveableInY()
    {
        if (SpriteTools.IsBelowMidScreen(CorgiSpriteRenderer))
            IsCorgiBelowMidScreen = true;
        else
            IsCorgiBelowMidScreen = false;

        return IsCorgiBelowMidScreen;
    }

    private void ApplyGravity(SpriteRenderer spriteRenderer)
    {
        //if (IsCorgiMoveableInY())
            spriteRenderer.transform.Translate(new Vector2(0, CalculateYVelocityDueToGravity()));
    }

    private float CalculateYVelocityDueToGravity()
    {
        if (IsCorgiMoveableInY())
        {
            // Vf = Vi - gt
            float finalYVelocity = initialYVelocity - GameParameters.GravityStrength;
            initialYVelocity = finalYVelocity;
            return finalYVelocity;
        }
        return 0.0f;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Platform")
        {
            initialYVelocity += GameParameters.PlatformBoostYVelocity;
            print("bruh");
        }
    }
}
