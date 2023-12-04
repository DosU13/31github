using System.Collections;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemyPrefab; // Reference to your enemy prefab
    public float circleRadius = 5f; // Radius of the circle
    public float interval = 0.2f; // interval between enemy spawns
    public float enemyHealth = 10f;
    public float damageAmount = 1f;
    public float priceAmount = 1f;

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
            spawnInterval = Random.Range(interval*0.7f, interval*1.3f);
        }
    }

    // Function to spawn an enemy around the circle
    void SpawnEnemy()
    {
        Vector3 spawnPosition = CalculateSpawnPosition();
        var enemy = Instantiate(enemyPrefab, spawnPosition, Quaternion.identity, transform);
        var enemyBehaviour = enemy.GetComponent<EnemyBehaviour>();
        enemyBehaviour.Health = enemyHealth;
        enemyBehaviour.DamageAmount = damageAmount;
        enemyBehaviour.PriceAmount = priceAmount;
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
