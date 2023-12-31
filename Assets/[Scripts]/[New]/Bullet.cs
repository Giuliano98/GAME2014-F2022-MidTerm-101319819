/*
 * Author: Giuliano Venturo Gonzales
 * Student ID: 101319819
 * Date Last Modified: 2023/10/20
 * Program Description: bullet for the player
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    //! bullet for my player
    public float speed = 10f; // Speed at which the bullet moves from left to right

    void Update()
    {
        transform.Translate(Vector3.right * speed * Time.deltaTime);

        // Get the width of the screen
        float screenWidth = Camera.main.orthographicSize * 2 * Camera.main.aspect;

        // Destroy the bullet if it goes off the screen either left or right
        if (Mathf.Abs(transform.position.x) > screenWidth / 2f)
        {
            Destroy(gameObject);
        }
    }
}
