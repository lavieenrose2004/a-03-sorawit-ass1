using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SuperHero 
{
    // Attributes
    protected string name;
    public string Name
    {
        get 
        {
            return name;        
        }

        set
        {
            if(value == null || value == "")
            {
                name = "N/A";
            }
            name = value;
        }
    }

    protected int hp;
    public int Hp { get { return hp; } set { hp = value; } }
    
    public string SuitColor { get; set; }

    private float armorStrength;


    public int GetHp()
    {
        return hp;
    }

    public string GetSuitColor()
    {
        return SuitColor;
    }

    // Constructor
    public SuperHero(string newName, int newHp, string newSuitColor)
    {
        name = newName;
        hp = newHp;
        SuitColor = newSuitColor;
        armorStrength = 10;
    }

    public void UpdateArmorStrength(float strength)
    {
        armorStrength += strength;
        Debug.Log($"********** {name} updated their strength {armorStrength}");
    }

    // New Method: TakeDamage
    public void TakeDamage(int damage)
    {
        hp -= damage;
        Debug.Log($"{name} took {damage} damage, remaining HP: {hp}");

        if (IsDead())
        {
            Debug.Log($"{name} is dead.");
        }
    }

    // New Method: IsDead
    public bool IsDead()
    {
        return hp <= 0;
    }
}
