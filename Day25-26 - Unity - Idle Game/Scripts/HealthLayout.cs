using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthLayout : LayoutScript
{
    private PlayerHealth shooter;

    new void Start()
    {
        base.Start();
        shooter = GameObject.FindWithTag("Player").GetComponent<PlayerHealth>();
    }

    public float amount;
    public override float Amount
    {
        get => amount;
        set
        {
            amount = value;
            shooter.health = amount;
        }
    }
}
