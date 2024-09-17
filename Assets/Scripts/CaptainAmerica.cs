using UnityEngine;

public class CaptainAmerica : SuperHero
{
   

    public void LeapAndJump()
    {
        Debug.Log($"----------{_name} is Leap and Jump");
    }

    public void ThrowShield()
    {
        Debug.Log($"=========={_name} is Throwing a Shield");
    }

    
}
