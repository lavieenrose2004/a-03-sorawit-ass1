using UnityEngine;

class CaptainAmerica : SuperHero
{
    public CaptainAmerica(string newName, int newHp, string newSuitColor) 
        : base(newName, newHp, newSuitColor)
    {

    }

    public void LeapAndJump()
    {
        Debug.Log($"----------{Name} is Leap and Jump");
    }

    public void ThrowShield()
    {
        Debug.Log($"=========={Name} is Throwing a Shield");
    }

    
}
