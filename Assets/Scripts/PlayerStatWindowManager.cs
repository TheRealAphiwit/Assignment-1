using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PlayerStatWindowManager : MonoBehaviour
{
    public LapManager lapManager;
    public PlayerController playerController1;
    public PlayerController playerController2;

    [SerializeField] TextMeshProUGUI player1LapText;
    [SerializeField] TextMeshProUGUI player2LapText;

    // Update is called once per frame
    void Update()
    {
        player1LapText.text = $"Laps: {playerController1.lapNumber}/{lapManager.totalLaps}";
        player2LapText.text = $"Laps: {playerController2.lapNumber}/{lapManager.totalLaps}";
    }
}
