using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoint : MonoBehaviour
{
    public int index;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("PlayerVehicle"))
        {
            PlayerController playerController = other.gameObject.GetComponentInParent<PlayerController>();
            if (playerController.checkpointIndex == index - 1)
            {
                Debug.Log("Check!");
                playerController.checkpointIndex = index;
            }
        }
    }
}
