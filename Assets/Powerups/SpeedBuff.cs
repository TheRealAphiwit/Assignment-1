using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Powerups/SpeedBuff")]
public class SpeedBuff : PowerUpEffect
{
    public float tempAmount;
    public float permAmount;

    public override void Apply(GameObject target)
    {
        target.GetComponent<Rigidbody>().AddRelativeForce(Vector3.forward * tempAmount);
        if(permAmount != 0)
        {
            target.GetComponentInParent<PlayerController>().speedMod += permAmount;
        }
    }
}
