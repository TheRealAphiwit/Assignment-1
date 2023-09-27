using System;
using System.ComponentModel.Design.Serialization;
using UnityEngine;

public class Init : MonoBehaviour
{
    [SerializeField] private GameState gameStatePrefab;

    private void Awake()
    {
        // Initialize the network service

        // Init the game state
        var gameState = Instantiate(gameStatePrefab);
        gameState.Initialize();

        // Init scene manager

        // Init input manager

        // Init UI

        LoaderService();
    }

    private void LoaderService()
    {
        throw new NotImplementedException();
    }
}
