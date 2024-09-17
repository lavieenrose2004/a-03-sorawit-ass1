using Unity.VisualScripting;
using UnityEngine;

public class Main : MonoBehaviour
{
    IronMan ironMan = new IronMan("Tony Stark", 100, "Red");
    private object ironman;
    CaptainAmerica captainAmerica = new CaptainAmerica("Steve Rogers", 100, "Blue");
    int round = 0;
    // Start is called before the first frame update
    void Start()
    {
       
        Debug.Log("====== Battle Begins ======");
        
        //Debug.Log($"IronMan Name is {ironman.Name} hp is : {ironman.G}");


    }

    private void Update()
    {
        if(ironMan.IsDead() || captainAmerica.IsDead())
        {
            
            return;
        }

        Debug.Log($"Round {round+ 1}");

        // IronMan attacks Captain America
        int damageIronMan = Random.Range(10, 21);
        ironMan.ShootLaser();
        captainAmerica.TakeDamage(damageIronMan);
        

        // Captain America attacks IronMan
        int damageCaptain = Random.Range(10, 21);
        captainAmerica.ThrowShield();
        ironMan.TakeDamage(damageCaptain);
        Debug.Log($"Round {round++}");
        //Debug.Log($"");
    }
}
