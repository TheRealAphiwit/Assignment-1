using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp : MonoBehaviour
{
    public PowerUpEffect powerUpEffect;

    [SerializeField] bool onField;
    [SerializeField] float downtime;

    private void Start()
    {
        onField = true;
    }

    private void Update()
    {
        if (onField == false)
        {
            Debug.Log("Item not on field!");
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        //Change from destroy
        GetComponent<MeshRenderer>().enabled = false;
        GetComponent<Collider>().enabled = false;
        onField = false;

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
