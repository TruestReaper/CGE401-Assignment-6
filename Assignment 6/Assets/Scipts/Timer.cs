/*
* Name: John Chirayil
* CGE401 - Assignment 6
* File: Timer.cs
* Desc: This code manages the timer in the
* prop hunt game.
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    public float timeRemaining = 300f;  // Set to 5 minutes (300 seconds)
    public Text timerText;
    private bool gameEnded = false;
    public AudioSource timesUpSound;

    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1;  // Ensure the game starts in normal time
        UpdateTimerDisplay();
    }

    // Update is called once per frame
    void Update()
    {
        if (!gameEnded)
        {
            Countdown();
        }
        else
        {
            // If the game has ended, check for the "R" or "M" key press
            if (Input.GetKeyDown(KeyCode.R))
            {
                RestartGame();
            }
            else if (Input.GetKeyDown(KeyCode.M))
            {
                ReturnToMainMenu();
            }
        }
    }

    void Countdown()
    {
        if (timeRemaining > 0)
        {
            timeRemaining -= Time.deltaTime;
            UpdateTimerDisplay();
        }
        else
        {
            timeRemaining = 0;
            EndGame();
        }
    }
    void UpdateTimerDisplay()
    {
        int minutes = Mathf.FloorToInt(timeRemaining / 60);
        int seconds = Mathf.FloorToInt(timeRemaining % 60);
        timerText.text = $"{minutes:00}:{seconds:00}";
    }

    void EndGame()
    {
        gameEnded = true;
        Debug.Log("Time's up! You lose.");
        timerText.text = "Time's up! Press 'R' to Retry or 'M' for Main Menu";
        timesUpSound.Play();

        // Freeze the game
        Time.timeScale = 0;
    }

    void RestartGame()
    {
        // Reset time scale back to normal when restarting
        Time.timeScale = 1;
        GameManager.Instance.RestartLevel();
    }

    void ReturnToMainMenu()
    {
        // Reset time scale back to normal when going to the main menu
        Time.timeScale = 1;
        GameManager.Instance.UnloadCurrentLevel();
    }

}
