using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceshipController : MonoBehaviour
{
    public float movementSpeed = 5f; // Speed at which the spaceship moves

    float minY, maxY; // Minimum and maximum Y positions for the spaceship

    void Start()
    {
        // Calculate the boundaries based on the screen size and aspect ratio
        float halfShipHeight = transform.localScale.y / 2f;
        minY = Camera.main.ViewportToWorldPoint(new Vector3(0, 0, 0)).y + halfShipHeight;
        maxY = Camera.main.ViewportToWorldPoint(new Vector3(0, 1, 0)).y - halfShipHeight;
    }

    void Update()
    {
        // Get the vertical input for both keyboard and touch
        float verticalInput = Input.GetAxis("Vertical");

        // Calculate the new Y position of the spaceship
        float newYPos = Mathf.Clamp(transform.position.y + verticalInput * movementSpeed * Time.deltaTime, minY, maxY);

        // Update the spaceship's position
        transform.position = new Vector3(transform.position.x, newYPos, transform.position.z);
    }
}
