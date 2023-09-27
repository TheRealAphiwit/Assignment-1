using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Game state service
public class GameState : MonoBehaviour
{
    public static GameState Instance;

    public void Initialize()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(Instance);
            GameStateStatusMessage("Instance has been set.");
            return;
        }

        GameStateStatusMessage("Duplicate detected! Destroying GO.");
        Destroy(gameObject);
    }

    private void GameStateStatusMessage(string GameStateContext)
    {
        Debug.Log(GameStateContext);
    }
}
