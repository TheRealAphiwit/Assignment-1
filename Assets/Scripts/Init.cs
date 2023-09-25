using System;
using System.ComponentModel.Design.Serialization;
using UnityEngine;

public class Init : MonoBehaviour
{
    [SerializeField] private GameState gameStatePrefab;

    private void Awake()
    {
        var gameState = Instantiate(gameStatePrefab);
        gameState.Initialize();
        LoaderService();
    }

    private void LoaderService()
    {
        throw new NotImplementedException();
    }
}
