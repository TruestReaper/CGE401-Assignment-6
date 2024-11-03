/*
* Name: John Chirayil
* File: Golem.cs
* CGE401 - Assignment 6
* Descripton: A Golem class derived from Enemy, with increased health,
* score increment, and implementations for attack and damage-taking behaviors.
*/

using System.Collections;
using System.Collections.Generic;
using Assets.Scipts;
using UnityEngine;

public class Golem : Enemy
{
    protected int damage;

    // Start is called before the first frame update
    protected override void Awake()
    {
        base.Awake();
        health = 120;
        GameManager.Instance.score += 2;
    }

    protected override void Attack(int amount)
    {
        Debug.Log("Golem attacks");
    }

    public override void TakeDamage(int amount)
    {
        Debug.Log("You took " + amount + " points of damage.");
    }
}
