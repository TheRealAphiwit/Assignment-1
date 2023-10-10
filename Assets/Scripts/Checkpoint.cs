using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoint : MonoBehaviour
{
    public Vector3 savedRespawnPoint;
    public Quaternion savedRespawnRotation;
    public int index;

    private void Awake()
    {
        savedRespawnPoint = transform.position;
        savedRespawnRotation = transform.rotation;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("PlayerVehicle"))
        {
            PlayerController playerController = other.gameObject.GetComponentInParent<PlayerController>();
            if (playerController.checkpointIndex == index - 1)
            {
                Debug.Log("Check!");
                playerController.checkpointIndex = index;
                playerController.playerSpawnPoint = savedRespawnPoint;
                playerController.playerSpawnRotation = savedRespawnRotation;
            }
        }
    }
}
