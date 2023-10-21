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
        //! using old and new input when necessary
        // Check for input to shoot bullets
        if (Input.GetKeyDown(KeyCode.Space))
        {
            ShootBullet();
        }
    }

    public void ShootBullet()
    {
        GameObject bullet = Instantiate(bulletPrefab, spawnPoint.position, Quaternion.identity);
    }
}
