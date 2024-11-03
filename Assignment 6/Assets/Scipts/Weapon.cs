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

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
