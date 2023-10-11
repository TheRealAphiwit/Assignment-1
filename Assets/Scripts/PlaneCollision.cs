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
            playerRb.transform.position = new Vector3(playerController.playerSpawnPoint.x, playerController.playerSpawnPoint.y + 2, playerController.playerSpawnPoint.z);
            playerRb.transform.rotation = playerController.playerSpawnRotation;
            playerRb.angularVelocity = Vector3.zero;
            playerRb.velocity = Vector3.zero;
        } else
        {
            Debug.Log("The object was not a player. MUST DESTROY!");
            Destroy(other.gameObject);
        }
    }
}
