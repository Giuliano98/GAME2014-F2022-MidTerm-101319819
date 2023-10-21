/*
 * Author: Giuliano Venturo Gonzales
 * Student ID: 101319819
 * Date Last Modified: 2023/10/20
 * Program Description: shooting bullets
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Shooting : MonoBehaviour
{
    public GameObject bulletPrefab; // Reference to the bullet prefab
    public Transform spawnPoint; // The position where bullets will be spawned

    void Update()
    {
        // Check for input to shoot bullets
        if (Input.GetKeyDown(KeyCode.Space))
        {
            ShootBullet();
        }
    }

    public void ShootBullet()
    {
        // Instantiate a new bullet at the spawn point
        GameObject bullet = Instantiate(bulletPrefab, spawnPoint.position, Quaternion.identity);
        //GameObject bullet = Instantiate(bulletPrefab, spawnPoint.position, bulletPrefab.transform.rotation);
        // Set the bullet's initial velocity (if necessary)
        // bullet.GetComponent<Rigidbody2D>().velocity = new Vector2(bulletSpeed, 0f);
    }
}
