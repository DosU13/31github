using System;
using System.Collections;
using UnityEngine;

public class PlayerShooter : MonoBehaviour
{
    [NonSerialized] public float shootingRange = 10f; // Range within which the player can shoot
    public float lineDuration = 0.1f; // Duration of the shot line
    [NonSerialized] public float interval = 1f;
    [NonSerialized] public float DamageAmount = 10f;

    private LineRenderer shotLine; // Reference to the LineRenderer
    private void Start()
    {
        shotLine = GetComponent<LineRenderer>();
        StartCoroutine(IdleShooting());
    }

    IEnumerator IdleShooting()
    {
        while (true)
        {
            yield return new WaitForSeconds(interval); // Adjust delay between shots if needed

            ShootAtNearestEnemy();
        }
    }

    void ShootAtNearestEnemy()
    {
        GameObject[] enemies = GameObject.FindGameObjectsWithTag("Enemy"); // Find all GameObjects tagged as "Enemy"
        GameObject nearestEnemy = null;
        float closestDistance = Mathf.Infinity;

        foreach (GameObject enemy in enemies)
        {
            float distanceToEnemy = Vector3.Distance(base.transform.position, enemy.transform.position);

            if (distanceToEnemy < closestDistance && distanceToEnemy <= shootingRange)
            {
                closestDistance = distanceToEnemy;
                nearestEnemy = enemy;
            }
        }

        if (nearestEnemy != null)
        {
            Vector3 endPos = nearestEnemy.transform.position;
            StartCoroutine(ShowShotLine(transform.position, endPos, lineDuration));

            nearestEnemy.GetComponent<EnemyBehaviour>().ApplyDamage(DamageAmount);
        }
    }

    IEnumerator ShowShotLine(Vector3 startPos, Vector3 endPos, float duration)
    {
        if (shotLine != null)
        {
            shotLine.enabled = true;
            shotLine.SetPosition(0, startPos);
            shotLine.SetPosition(1, endPos);

            yield return new WaitForSeconds(duration);

            shotLine.enabled = false;
        }
    }
}
