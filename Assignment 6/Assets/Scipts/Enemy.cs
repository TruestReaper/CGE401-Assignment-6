using System.Collections;
using UnityEngine;

namespace Assets.Scipts
{
    public abstract class Enemy : MonoBehaviour, IDamageable
    {
        protected float speed;
        protected int health;

        [SerializeField] protected Weapon weapon;

        protected virtual void Awake()
        {
            weapon = gameObject.AddComponent<Weapon>();

            speed = 5f;
            health = 100;

            weapon.damageBonus = 10;
        }

        protected abstract void Attack(int amount);

        public abstract void TakeDamage(int amount);

        // Use this for initialization
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}