using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LapManager : MonoBehaviour
{
    public GameObject lapLine;
    public List<Checkpoint> checkpoints;
    public int totalLaps;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("PlayerVehicle"))
        {
            PlayerController playerController = other.gameObject.GetComponent<PlayerController>();
            if (playerController.checkpointIndex == checkpoints.Count)
            {
                playerController.checkpointIndex = 0;
                playerController.lapNumber++;

                Debug.Log($"You are on lap {playerController.lapNumber} / {totalLaps}");

                if (playerController.lapNumber >= totalLaps)
                {
                    Debug.Log("Game finnished!");
                }
            }
        }
    }
}
