using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedLayout : LayoutScript
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
            amount = (float)Math.Round(value, 2);
            shooter.interval = amount;
        }
    }
}
