using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundStarsBehaviour : MonoBehaviour
{
    public float horizontalSpeed = 1f; // Speed at which the background scrolls from right to left

    private float backgroundWidth;
    private float screenWidth;

    void Start()
    {
        // Get the SpriteRenderer component of the background
        SpriteRenderer spriteRenderer = GetComponent<SpriteRenderer>();

        if (spriteRenderer != null && spriteRenderer.sprite != null)
        {
            // Calculate the background width from the sprite bounds
            backgroundWidth = spriteRenderer.bounds.size.x;

            // Calculate the screen width based on the camera size and aspect ratio
            screenWidth = Camera.main.orthographicSize * 2 * Camera.main.aspect;
        }
        else
        {
            Debug.LogError("SpriteRenderer component or sprite not found on the background GameObject!");
        }
    }

    void Update()
    {
        Move();
        CheckBounds();
    }

    void Move()
    {
        // Move the background horizontally from right to left
        transform.position -= new Vector3(horizontalSpeed * Time.deltaTime, 0f, 0f);
    }

    void CheckBounds()
    {
        // Reset the background position if it moves completely off the screen to the left
        if (transform.position.x + backgroundWidth / 2f < -screenWidth / 2f)
        {
            // Reset the background's position to the right side of the screen
            transform.position = new Vector3(screenWidth / 2f + backgroundWidth / 2f, transform.position.y, transform.position.z);
        }
    }
}
