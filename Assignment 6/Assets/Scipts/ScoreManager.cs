/*
* Name: John Chirayil
* CGE401 - Assignment 6
* File: ScoreManager.cs
* Desc: This code manages the score system in
* the prop hunt game.
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreManager : MonoBehaviour
{
    public Text scoreText;
    private int score = 0;
    private int targetScore = 10;
    private bool gameEnded = false;
    public AudioSource winSound;

    // Start is called before the first frame update
    void Start()
    {
        UpdateScoreDisplay();
    }

    // Update is called once per frame
    void Update()
    {
        if (gameEnded)
        {
            if (Input.GetKeyDown(KeyCode.R))
            {
                RestartGame();
            }
            else if (Input.GetKeyDown(KeyCode.M))
            {
                LoadMainMenu();
            }
        }
    }
    public void AddScore()
    {
        if (gameEnded) return;

        score++;
        UpdateScoreDisplay();

        if (score >= targetScore)
        {
            winSound.Play();
            EndGame();
        }
    }

    void UpdateScoreDisplay()
    {
        scoreText.text = $"Props Found: {score}/10";
    }

    void EndGame()
    {
        gameEnded = true;
        Debug.Log("You've found all the props! You win!");
        scoreText.text = $"You win! Press 'R' to Retry. Press 'M' for Main Menu";

        // Freeze the game
        Time.timeScale = 0;
    }

    void RestartGame()
    {
        // Reset time scale back to normal and reload the scene
        Time.timeScale = 1;
        GameManager.Instance.RestartLevel();
    }

    void LoadMainMenu()
    {
        // Reset time scale back to normal and load the main menu scene
        Time.timeScale = 1;
        GameManager.Instance.UnloadCurrentLevel();
    }
}
