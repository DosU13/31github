using System.Collections;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemyPrefab; // Reference to your enemy prefab
    public float circleRadius = 5f; // Radius of the circle
    public float minInterval = 0.1f; // Minimum interval between enemy spawns
    public float maxInterval = 0.3f; // Maximum interval between enemy spawns

    private float timer = 0f;
    private float spawnInterval = 1f; // Initial spawn interval

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        if (timer >= spawnInterval)
        {
            SpawnEnemy();
            timer = 0f;

            // Set a new random spawn interval between the defined range
            spawnInterval = Random.Range(minInterval, maxInterval);
        }
    }

    // Function to spawn an enemy around the circle
    void SpawnEnemy()
    {
        Vector3 spawnPosition = CalculateSpawnPosition();
        Instantiate(enemyPrefab, spawnPosition, Quaternion.identity, transform);
    }

    // Calculate the spawn position around the circle
    Vector3 CalculateSpawnPosition()
    {
        float angle = Random.Range(0f, 360f); // Get a random angle within the circle
        float x = transform.position.x + Mathf.Cos(angle * Mathf.Deg2Rad) * circleRadius;
        float y = transform.position.y + Mathf.Sin(angle * Mathf.Deg2Rad) * circleRadius;
        Vector3 spawnPosition = new Vector3(x, y, 0);
        return spawnPosition;
    }
}
