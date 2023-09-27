using System;
using System.ComponentModel.Design.Serialization;
using UnityEngine;

public class InitMonobehaviour : MonoBehaviour
{
    [SerializeField] private GameState gameStatePrefab;

    private void Awake()
    {
        // Init network

        // Init game state
        LoadGameState();

        // Init scene manager

        // Init input manager

        // Init UI
        
        LoaderService();

    }

    private void LoadGameState()
    {
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
