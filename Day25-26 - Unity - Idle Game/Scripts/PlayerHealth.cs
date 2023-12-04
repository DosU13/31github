using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public float health = 50;
    public TextMeshProUGUI healthText; // Correcting the TextMeshProUGUI variable

    private GameManager gameManager;

    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>(); // Find the GameManager by name
        UpdateHealthText(); // Update health text initially
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void ApplyDamage(float damage)
    {
        health -= damage;
        UpdateHealthText(); // Update health text when taking damage
        if (health <= 0) gameManager.GameOver(); // Check for health reaching zero or below
    }

    void UpdateHealthText()
    {
        // Update the health text using the 'I' character for each unit of health
        healthText.text = new string('I', (int)health);
    }

    public void OnTriggerEnter2D(Collider2D col)
    {
        // Check if the collided object is the player
        if (col.CompareTag("Enemy"))
        {
            // Get the PlayerHealth script from the player object
            var enemyBehaviour = col.GetComponent<EnemyBehaviour>();

            ApplyDamage(enemyBehaviour.Health);
            enemyBehaviour.Kill();
        }
    }
}
