using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Player : MonoBehaviour
{
    public UnityEvent OnHealthChange;
    public UnityEvent OnMaxHealthChange;

    [SerializeField] private int maxHealth = 100;
    [SerializeField] private int currentHealth;

    private int id;
    public int Id { get => id; set => id = value; }
    public int CurrentHealth { get => currentHealth; set 
        {
            currentHealth = value;
            OnHealthChange.Invoke();
        }
    }
    public int MaxHealth { get => maxHealth;
        set
        { 
            maxHealth = value;
            if (maxHealth < currentHealth)
            {
                CurrentHealth = MaxHealth;
            }
            OnMaxHealthChange.Invoke();
        }
    }

    public Player() 
    { 

    }

    void TakeDamage(int damage)
    {
        CurrentHealth -= damage;
        //OnHealthChange.Invoke();
    }

    private void Start()
    {
        CurrentHealth = MaxHealth;
        //OnHealthChange.Invoke();
    }
    private void Update()
    {

    }

    /*private void OnCollisionEnter2D(Collision2D collision)
    {
        TakeDamage(10);
    }*/
}
