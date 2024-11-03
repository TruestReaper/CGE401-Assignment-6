/*
* Name: John Chirayil
* File: Weapon.cs
* CGE401 - Assignment 6
* Descripton: A Weapon class that grants a damage bonus, 
* interacts with an enemy, and includes a recharge 
* functionality.
*/

using System.Collections;
using System.Collections.Generic;
using Assets.Scipts;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    public int damageBonus;
    public Enemy enemyHoldingWeapon;

    private void Awake()
    {
        enemyHoldingWeapon = GetComponent<Enemy>();
        EnemyEatsWeapon(enemyHoldingWeapon);
    }

    protected void EnemyEatsWeapon(Enemy enemy)
    {
        Debug.Log("Enemy eats weapon");
    }

    public void Recharge()
    {
        Debug.Log("Recharging weapon");
    }
}
