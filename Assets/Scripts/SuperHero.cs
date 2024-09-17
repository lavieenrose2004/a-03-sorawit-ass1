using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SuperHero : MonoBehaviour
{
    // Attributes
    protected string _name;
    public string Name
    {
        get 
        {
            return _name;        
        }

        set
        {
            if(value == null || value == "")
            {
                _name = "N/A";
            }
            _name = value;
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
    

    public void UpdateArmorStrength(float strength)
    {
        armorStrength += strength;
        Debug.Log($"********** {_name} updated their strength {armorStrength}");
    }

    // New Method: TakeDamage
    public void TakeDamage(int damage)
    {
        hp -= damage;
        Debug.Log($"{_name} took {damage} damage, remaining HP: {hp}");

        if (IsDead())
        {
            Debug.Log($"{_name} is dead.");
        }
    }

    // New Method: IsDead
    public bool IsDead()
    {
        return hp <= 0;
    }
}
