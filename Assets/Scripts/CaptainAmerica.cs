using UnityEngine;

class CaptainAmerica : SuperHero
{
    public CaptainAmerica(string newName, int newHp, string newSuitColor) 
        : base(newName, newHp, newSuitColor)
    {

    }

    public void LeapAndJump()
    {
        Debug.Log($"----------{name} is Leap and Jump");
    }

    public void ThrowShield()
    {
        Debug.Log($"=========={name} is Throwing a Shield");
    }

    
}
