using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp : MonoBehaviour
{
    public PowerUpEffect powerUpEffect;

    private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
        if (other.CompareTag("PlayerVehicle"))
        {
            Debug.Log("Collision with player detected!");
            powerUpEffect.Apply(other.gameObject);
        } else
        {
            Debug.Log("Non player collision");
        }
    }
}
