using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehaviour : MonoBehaviour
{
    public float movementSpeed = 3f; // Speed of the enemy movement
    private Transform player; // Reference to the player's transform

    [NonSerialized] public float Health;
    [NonSerialized] public float DamageAmount;
    [NonSerialized] public float PriceAmount;
    
    private GameManager manager;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform; // Find the player GameObject
        manager = FindAnyObjectByType<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if (player != null)
        {
            MoveTowardsPlayer();
        }
    }

    // Move the enemy towards the player
    void MoveTowardsPlayer()
    {
        // Calculate the direction to move towards the player
        Vector3 direction = (player.position - transform.position).normalized;

        // Move the enemy towards the player
        transform.Translate(direction * movementSpeed * Time.deltaTime);
    }

    internal void ApplyDamage(float damage)
    {
        Health -= damage;
        if (Health <= 0) Kill();
    }

    public void Kill()
    {
        manager.RewardMoney(PriceAmount);
        Destroy(gameObject);
    }
}
