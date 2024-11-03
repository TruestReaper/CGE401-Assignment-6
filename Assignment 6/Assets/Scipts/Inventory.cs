/*
* Name: John Chirayil
* File: Inventory.cs
* CGE401 - Assignment 6
* Descripton: An Inventory class that manages a list of 
* InventoryItem objects and initializes an inventory at the start.
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scipts
{
    public class Inventory : MonoBehaviour
    {
        [SerializeField] private InventoryItem item;
        public List<InventoryItem> inventory;

        // Use this for initialization
        void Start()
        {
            item = new InventoryItem();
            inventory = new List<InventoryItem>();
        }
    }
}