/*
* Name: John Chirayil
* File: LockCursor.cs
* CGE401 - Assignment 6
* Descripton: This code will lock the cursor
* during gameplay. 
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LockCursor : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // esc
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }
}
