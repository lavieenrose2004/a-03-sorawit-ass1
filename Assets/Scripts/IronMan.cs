using UnityEngine;

class IronMan
{
    // Attributes
    public string Name;
    public int Hp;
    public string SuitColor;
    private float armorStrength;

    // Constructor
    public IronMan(string newName, int newHp, string newSuitColor)
    {
        Name = newName;
        Hp = newHp;
        SuitColor = newSuitColor;
        armorStrength = 10;
    }

    public void Fly()
    {
        Debug.Log($"----------{Name} is flying");
    }

    public void ShootLaser()
    {
        Debug.Log($"=========={Name} is shooting laser");
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
