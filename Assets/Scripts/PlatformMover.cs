using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformMover : MonoBehaviour
{
    public SpriteTools SpriteTools;
    public Corgi Corgi;
    public SpriteRenderer PlatformSpriteRenderer;

    private bool isPlatformMoveable = false;

    private void Update()
    {
        
    }

    private bool IsPlatformMoveable()
    {
        if (Corgi.IsCorgiBelowMidScreen)
            isPlatformMoveable = false;
        isPlatformMoveable = true;

        return isPlatformMoveable;
    }

    private void Move()
    {
        Vector2 amountToMove = CalculateAmountToMoveX(direction);
        PlatformSpriteRenderer.transform.Translate(amountToMove);
    }

    private void ApplyMovement()
    {
        if (IsPlatformMoveable())
        {
            Corgi.IsCorgiBelowMidScreen = false;

        }
    }


}
