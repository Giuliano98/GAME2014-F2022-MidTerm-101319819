using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 10f; // Speed at which the bullet moves from left to right

    void Update()
    {
        // Move the bullet from left to right
        transform.Translate(Vector3.right * speed * Time.deltaTime);

        // Destroy the bullet if it goes off the screen
        if (transform.position.x > Camera.main.orthographicSize * 2 * Camera.main.aspect)
        {
            Destroy(gameObject);
        }
    }
}
