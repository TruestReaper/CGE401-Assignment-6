/*
* Name: John Chirayil
* File: IDamageable.cs
* CGE401 - Assignment 6
* Descripton: An interface for damageable objects, 
* requiring implementation of a method to take damage.
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IDamageable 
{
    void TakeDamage(int amount);
}
