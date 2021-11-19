using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyboardInput : MonoBehaviour
{
    public Corgi Corgi;

    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            // move corgi left
            Corgi.MoveWithKeyboard(new Vector2(-1, 0));
        }

        if (Input.GetKey(KeyCode.D))
        {
            // move corgi right
            Corgi.MoveWithKeyboard(new Vector2(1, 0));
        }

    }

}
