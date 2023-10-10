using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneDirector : MonoBehaviour
{
    [SerializeField] PlayerController playerController1;
    [SerializeField] PlayerController playerController2;
    [SerializeField] LapManager lapManager;

    private void Awake()
    {
        playerController1.lapNumber = 0;
        playerController2.lapNumber = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (playerController1.lapNumber >= lapManager.totalLaps)
        {
            Debug.Log("Player 1 won!");
            if (SceneManager.GetActiveScene().buildIndex < SceneManager.sceneCountInBuildSettings)
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            } else if (SceneManager.GetActiveScene().buildIndex >= SceneManager.sceneCountInBuildSettings)
            {
                Debug.Log("There are no more scenes to load!");
            }
        }
        else if (playerController2.lapNumber >= lapManager.totalLaps)
        {
            Debug.Log("player 2 won!");
            if (SceneManager.GetActiveScene().buildIndex > SceneManager.sceneCountInBuildSettings)
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            }
            else
            {
                Debug.Log("There are no more scenes to load!");
            }
        }
    }
}
