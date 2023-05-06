using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Burst.Intrinsics;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 10.0f;

    void Update()
    {
        float x = Input.GetAxisRaw("Horizontal");   // Input on the x-Axis
        float y = Input.GetAxisRaw("Vertical");     // Input on the y-Axis

        Vector2 direction = new Vector2(x, y).normalized;   // Calculate direction vector and normalize it to a unit vector

        Move(direction);    // Call function, that sets player's position
    }

    void Move(Vector2 direction)
    {
        Vector2 pos = transform.position;       // Get player's current position
        pos += Time.deltaTime * speed * direction;     // Calculate player's new position
        

        transform.position = pos;   // Update player's position
    }
}
