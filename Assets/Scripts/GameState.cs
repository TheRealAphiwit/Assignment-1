using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Game state service
public class GameState : MonoBehaviour
{
    public static GameState Instance { get; private set; }

    public void Initialize()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(Instance);
            return;
        }

        Destroy(gameObject);
    }
}
