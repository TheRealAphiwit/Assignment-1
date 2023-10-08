using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaneCollision : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("PlayerVehicle"))
        {
            PlayerController playerController = other.gameObject.GetComponentInParent<PlayerController>();
            Rigidbody playerRb = other.gameObject.GetComponentInParent<Rigidbody>();
            playerRb.transform.position = playerController.playerSpawnPoint;
        } else
        {
            Debug.Log("The object was not a player. MUST DESTROY!");
            Destroy(other.gameObject);
        }
    }
}
