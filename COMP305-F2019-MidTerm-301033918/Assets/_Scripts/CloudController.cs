using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Util;
/// <summary>
/// Source File: CloudController.cs
/// Last Modified by: Geerthan Kanthasamy
/// This program moves the Cloud GameObject and resets it's position when it reaches it's specified boundary
/// </summary>
public class CloudController : MonoBehaviour
{
    [Header("Speed Values")]
    [SerializeField]
    public Speed horizontalSpeedRange;

    [SerializeField]
    public Speed verticalSpeedRange;

    public float verticalSpeed;
    public float horizontalSpeed;

    [SerializeField]
    public Boundary boundary;

    // Start is called before the first frame update
    void Start()
    {
        Reset();
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
        horizontalSpeed = Random.Range(horizontalSpeedRange.min, horizontalSpeedRange.max);
        verticalSpeed = Random.Range(verticalSpeedRange.min, verticalSpeedRange.max);

        if(verticalSpeed > 0)
        {
            float randomXPosition = Random.Range(boundary.Left, boundary.Right);
            transform.position = new Vector2(randomXPosition, Random.Range(boundary.Top, boundary.Top + 2.0f));
        }

        else if(horizontalSpeed > 0)
        {
            float randomYPosition = Random.Range(boundary.Bottom, boundary.Top);
            transform.position = new Vector2(Random.Range(boundary.Right, boundary.Right + 2.0f), randomYPosition);
        }
    }

    /// <summary>
    /// This method checks if the ocean reaches the lower boundary
    /// and then it Resets it
    /// </summary>
    void CheckBounds()
    {
        if (verticalSpeed > 0 && transform.position.y <= boundary.Bottom)
        {
            Reset();
        }

        else if (horizontalSpeed > 0 && transform.position.x <= boundary.Left)
        {
            Reset();
        }
    }
}
