using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp : MonoBehaviour
{
    public PowerUpEffect powerUpEffect;

    private void Update()
    {
        //bool check and timer
    }

    private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject); //Change from destroy
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
