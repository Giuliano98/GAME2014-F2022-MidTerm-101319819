using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float moveSpeed = 5f; // Speed at which the enemy moves
    public float verticalSpeed = 2f; // Speed of vertical movement
    public GameObject bulletPrefab; // Reference to the bullet prefab
    public Transform bulletSpawnPoint; // The position where bullets will be spawned

    private bool movingUp = true;

    void Start()
    {
        // Set the initial position of the enemy to the right side of the screen
        float screenHeight = Camera.main.orthographicSize * 2;
        float screenWidth = screenHeight * Camera.main.aspect;
        transform.position = new Vector3(screenWidth / 2f, Random.Range(-screenHeight / 2f, screenHeight / 2f), 0f);

        // Set initial movement to the left
        moveSpeed = -Mathf.Abs(moveSpeed);
    }

    void Update()
    {
        Move();
        Shoot();
    }

    void Move()
    {
        // Move the enemy horizontally to the left
        transform.Translate(Vector3.right * moveSpeed * Time.deltaTime);

        // Move the enemy vertically
        float newY = transform.position.y + (movingUp ? 1 : -1) * verticalSpeed * Time.deltaTime;
        transform.position = new Vector3(transform.position.x, newY, transform.position.z);

        // Check if the enemy has hit the screen borders vertically
        float screenHeight = Camera.main.orthographicSize;
        if (Mathf.Abs(transform.position.y) > screenHeight)
        {
            // Reverse the vertical movement direction when hitting the screen borders
            movingUp = !movingUp;
        }

        // Destroy the enemy if it moves beyond the left border
        if (transform.position.x < -Camera.main.orthographicSize * Camera.main.aspect)
        {
            Destroy(gameObject);
        }
    }

    void Shoot()
    {
        // // Shoot bullets at regular intervals
        // timeSinceLastShot += Time.deltaTime;
        // if (timeSinceLastShot >= shootInterval)
        // {
        //     // Instantiate a new bullet at the bullet spawn point
        //     GameObject bullet = Instantiate(bulletPrefab, bulletSpawnPoint.position, Quaternion.identity);
        //     // Set the bullet's initial velocity to move towards the left
        //     bullet.GetComponent<Rigidbody2D>().velocity = new Vector2(-moveSpeed * 2, 0f);
        //     // Reset the time since the last shot
        //     timeSinceLastShot = 0f;
        // }
    }
}