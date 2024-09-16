using UnityEngine;

class CaptainAmerica
{
    // Attributes
    public string Name;
    public int Hp;
    public string SuitColor;
    private float armorStrength;

    // Constructor
    public CaptainAmerica(string newName, int newHp, string newSuitColor)
    {
        Name = newName;
        Hp = newHp;
        SuitColor = newSuitColor;
        armorStrength = 10;
    }

    public void LeapAndJump()
    {
        Debug.Log($"----------{Name} is Leap and Jump");
    }

    public void ThrowShield()
    {
        Debug.Log($"=========={Name} is Throwing a Shield");
    }

    public void UpdateArmorStrength(float strength)
    {
        armorStrength += strength;
        Debug.Log($"********** {Name} updated their strength {armorStrength}");
    }

    // New Method: TakeDamage
    public void TakeDamage(int damage)
    {
        Hp -= damage;
        Debug.Log($"{Name} took {damage} damage, remaining HP: {Hp}");

        if (IsDead())
        {
            Debug.Log($"{Name} is dead.");
        }
    }

    // New Method: IsDead
    public bool IsDead()
    {
        return Hp <= 0;
    }
}
