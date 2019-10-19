using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// Source File: OceanController.cs
/// Last Modified by: Geerthan Kanthasamy
/// This program moves the Ocean GameObjects (background) and resets it's position when it reaches it's specified boundary
/// </summary>
public class OceanController : MonoBehaviour
{
    public float verticalSpeed = 0.1f;
    public float horizontalSpeed = 0.1f;
    public float resetPositionY = 4.8f;
    public float resetPositionX = 4.8f;
    public float resetPointY = -4.8f;
    public float resetPointX = -4.8f;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Move();
        CheckBounds();
    }

    /// <summary>
    /// This method moves the ocean down the screen by verticalSpeed
    /// </summary>
    void Move()
    {
        Vector2 newPosition = new Vector2(horizontalSpeed, verticalSpeed);
        Vector2 currentPosition = transform.position;

        currentPosition -= newPosition;
        transform.position = currentPosition;
    }

    /// <summary>
    /// This method resets the ocean to the resetPosition
    /// </summary>
    void Reset()
    {
        transform.position = new Vector2(resetPositionX, resetPositionY);
    }

    /// <summary>
    /// This method checks if the ocean reaches the lower boundary
    /// and then it Resets it
    /// </summary>
    void CheckBounds()
    {
        if(verticalSpeed > 0 && transform.position.y <= resetPointY)
        {
            Reset();
        }

        else if(horizontalSpeed > 0 && transform.position.x <= resetPointX)
        {
            Reset();
        }
    }
}
