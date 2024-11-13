/*
* Name: John Chirayil
* File: Singleton.cs
* CGE401 - Assignment 6
* Descripton: A generic Singleton class to ensure only one 
* instance of type T exists in a scene, with global access.
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Singleton<T> : MonoBehaviour where T : Singleton<T>
{
    private static T instance;
    public static T Instance {  get { return instance; } }

    public static bool IsInitialized { get { return instance != null; } }

    private void Awake()
    {
        if (instance != null)
        {
            Debug.LogError("[Singleton] Trying to instantiate a" +
                "second instance of a singleton class.");

        }
        else
        {
            instance = (T)this;
        }
    }

    protected virtual void OnDestroy()
    {
        // if this object is destroyed, make instance null so another can be created
        if (instance == this)
        {
            instance = null;
        }
    }
}
