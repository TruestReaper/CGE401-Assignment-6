/*
* Name: John Chirayil
* CGE401 - Assignment 6
* File: Prop.cs
* Desc: This code will increment the score
* when a prop gets shot.
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Prop : MonoBehaviour
{
    public float health = 10f;
    public AudioSource vanishSound;
    private ScoreManager scoreManager;

    void Start()
    {
        scoreManager = FindObjectOfType<ScoreManager>();
    }

    public void TakeDamage(float amount)
    {
        health -= amount;

        if (health <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        vanishSound.Play();
        scoreManager.AddScore();
        Destroy(gameObject);
    }
}
