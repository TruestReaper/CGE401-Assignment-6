/*
* Name: John Chirayil
* File: GameManager.cs
* CGE401 - Assignment 6
* Descripton: A GameManager class implementing the Singleton 
* pattern to manage game state, level loading, and pausing 
* functionality across scenes.
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public  class GameManager : Singleton<GameManager>, IPauseHandler
{
    public int score;

    public GameObject pauseMenu;
    public GameObject propHuntList;
    public GameObject instructions;

    // variable to keep track of what level we are on
    private string CurrentLevelName = string.Empty;


    /*#region This code makes this class a Singleton
    public static GameManager instance;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;

            //make sure this game manager persists across scenes
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
            Debug.LogError("Trying to instantiate a second" +
                "instance of singleton Game Manager");
        }
    }
    #endregion*/

    // methods to load and unload scenes

    public void LoadLevel(string levelName)
    {
        AsyncOperation ao = SceneManager.LoadSceneAsync(levelName, LoadSceneMode.Additive);
        if (ao == null)
        {
            Debug.LogError("[GameManager] Unable to load level " + levelName);
            return;
        }
        CurrentLevelName = levelName;
    }

    public void UnloadLevel(string levelName)
    {
        AsyncOperation ao = SceneManager.UnloadSceneAsync(levelName);
        if (ao == null)
        {
            Debug.LogError("[GameManager] Unable to unload level " + levelName);
            return;
        }
    }

    public void UnloadCurrentLevel()
    {
        AsyncOperation ao = SceneManager.UnloadSceneAsync(CurrentLevelName);
        if (ao == null)
        {
            Debug.LogError("[GameManager] Unable to unload level " + CurrentLevelName);
            return;
        }
    }

    // pausing and unpausing
    public void Pause()
    {
        Time.timeScale = 0f;
        pauseMenu.SetActive(true);
    }

    public void Unpause()
    {
        Time.timeScale = 1f;
        pauseMenu.SetActive(false);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            Pause();
        }

        if (Input.GetKeyDown(KeyCode.O)) 
        {
            TogglePropHuntList();
        }

        if (Input.GetKeyDown(KeyCode.I))
        {
            ToggleInstructions();
        }
    }

    public void TogglePropHuntList()
    {
        //Time.timeScale = 0f;
        // Toggle the active state of the prop hunt list
        propHuntList.SetActive(true);
    }

    public void UntogglePropHuntList()
    {
        //Time.timeScale = 1f;
        // Toggle the active state of the prop hunt list
        propHuntList.SetActive(false);
    }

    public void ToggleInstructions()
    {
        //Time.timeScale = 0f;
        // Toggle the active state of the prop hunt list
        instructions.SetActive(true);
    }

    public void UntoggleInstructions()
    {
        //Time.timeScale = 1f;
        // Toggle the active state of the prop hunt list
        instructions.SetActive(false);
    }
}
