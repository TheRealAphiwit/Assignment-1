using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public static bool GameIsPaused = false;

    public GameObject pauseMenuUI;
    public GameObject playerStatsUI;

    // Update is called once per frame
    void Update()
    {
        if (GameIsPaused)
        {
            pauseMenuUI.SetActive(true);
            playerStatsUI.SetActive(false);
            Time.timeScale = 0f;
        }
        else
        {
            pauseMenuUI.SetActive(false);
            playerStatsUI.SetActive(true);
            Time.timeScale = 1f;
        }
    }

    public void OnPause_OnResume()
    {
        if (GameIsPaused == false)
        {
            GameIsPaused = true;
        } else if (GameIsPaused == true)
        {
            GameIsPaused = false;
        }
        Debug.Log("Input pressed!");
    }

    public void LoadMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("MainMenu");
    }

    public void QuitGame()
    {
        Debug.Log("Quit game!");
        Application.Quit(); 
    }
}
