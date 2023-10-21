/*
 * Author: Giuliano Venturo Gonzales
 * Student ID: 101319819
 * Date Last Modified: 2023/10/20
 * Program Description: spawn enemy in scene
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemyPrefab; // Reference to the enemy prefab you want to spawn
    public float spawnInterval = 3f; // Time interval between enemy spawns
    public Transform spawnPoint; // The position where the enemy will be spawned
    public float intervalVariation = 0.2f;

    private float timeSinceLastSpawn = 0f;

    void Start()
    {
        SpawnEnemy();
    }


    void Update()
    {
        // Update the timer
        timeSinceLastSpawn += Time.deltaTime;

        // Check if it's time to spawn a new enemy
        if (timeSinceLastSpawn >= spawnInterval)
        {
            SpawnEnemy();
            timeSinceLastSpawn = 0f; // Reset the timer
        }
    }

    void SpawnEnemy()
    {
        // Instantiate the enemy prefab at the spawn point
        Instantiate(enemyPrefab, spawnPoint.position, spawnPoint.rotation);
    }
}
