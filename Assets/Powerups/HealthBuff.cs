using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Powerups/HealthBuff")]
public class HealthBuff : PowerUpEffect
{
    public float healAmount;
    public float maxHPIncreaseAmount;

    public override void Apply(GameObject target)
    {
        target.GetComponentInParent<PlayerController>().maxHealth += maxHPIncreaseAmount;
        target.GetComponentInParent<PlayerController>().health += healAmount;
    }
}
