using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp : MonoBehaviour
{
    public PowerUpEffect powerUpEffect;

    [SerializeField] bool onField;
    [SerializeField] float timeToMatch;
    [SerializeField] float tempTime;

    private void Awake()
    {
        onField = true;
    }

    private void Update()
    {
        if (onField == false)
        {
            tempTime += Time.deltaTime;
            if (tempTime >= timeToMatch)
            {
                SetPowerUpCondition(true);
                tempTime = 0;
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        //Change from destroy
        SetPowerUpCondition(false);

        if (other.CompareTag("PlayerVehicle"))
        {
            Debug.Log("Collision with player detected!");
            powerUpEffect.Apply(other.gameObject);
        } else
        {
            Debug.Log("Non player collision");
        }
    }

    private void SetPowerUpCondition(bool condition)
    {
        GetComponent<MeshRenderer>().enabled = condition;
        GetComponent<Collider>().enabled = condition;
        onField = condition;
    }
}
