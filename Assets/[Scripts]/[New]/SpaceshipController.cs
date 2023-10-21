/*
 * Author: Giuliano Venturo Gonzales
 * Student ID: 101319819
 * Date Last Modified: 2023/10/20
 * Program Description: controller for spaceship
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class SpaceshipController : MonoBehaviour
{
    //! New input sytem
    public InputAction playerMovement;
    public float movementSpeed = 5f; // Speed at which the spaceship moves
    float minY, maxY; // Minimum and maximum Y positions for the spaceship

    private void OnEnable()
    {
        playerMovement.Enable();
    }
    private void OnDisable()
    {
        playerMovement.Disable();
    }

    void Start()
    {
        //! boundaries
        // Calculate the boundaries based on the screen size and aspect ratio
        float halfShipHeight = transform.localScale.y / 2f;
        minY = Camera.main.ViewportToWorldPoint(new Vector3(0, 0, 0)).y + halfShipHeight;
        maxY = Camera.main.ViewportToWorldPoint(new Vector3(0, 1, 0)).y - halfShipHeight;
    }

    void Update()
    {
        //! using the New input sytem
        // Get the vertical input for both keyboard and touch
        float verticalInput = playerMovement.ReadValue<float>();
        // Calculate the new Y position of the spaceship
        float newYPos = Mathf.Clamp(transform.position.y + verticalInput * movementSpeed * Time.deltaTime, minY, maxY);

        // Update the spaceship's position
        transform.position = new Vector3(transform.position.x, newYPos, transform.position.z);
    }
}
