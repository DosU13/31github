using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RangeLayout : LayoutScript
{
    private PlayerShooter shooter;

    new void Start()
    {
        base.Start();
        shooter = GameObject.FindWithTag("Player").GetComponent<PlayerShooter>();
    }

    public float amount;
    public override float Amount
    {
        get => amount;
        set
        {
            amount = value;
            shooter.shootingRange = amount;
        }
    }
}
