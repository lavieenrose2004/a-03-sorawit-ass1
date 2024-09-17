using UnityEngine;

class IronMan : SuperHero
{
    public IronMan(string newName, int newHp, string newSuitColor) 
        : base(newName, newHp, newSuitColor)
    {

    }

    public void Fly()
    {
        Debug.Log($"----------{Name} is flying");
    }

    public void ShootLaser()
    {
        Debug.Log($"=========={Name} is shooting laser");
    }

    
}
