using Unity.VisualScripting;
using UnityEngine;

public class Main : MonoBehaviour
{
    IronMan ironMan = new IronMan("Tony Stark", 100, "Red");
    CaptainAmerica captainAmerica = new CaptainAmerica("Steve Rogers", 100, "Blue");
    int round = 0;
    // Start is called before the first frame update
    void Start()
    {
       
        Debug.Log("====== Battle Begins ======");

    }

    private void Update()
    {
        if(ironMan.IsDead() || captainAmerica.IsDead())
        {
            
            return;
        }

        Debug.Log($"Round {round++}");
        // IronMan attacks Captain America
        int damageIronMan = Random.Range(10, 21);
        ironMan.ShootLaser();
        captainAmerica.TakeDamage(damageIronMan);
        

        // Captain America attacks IronMan
        int damageCaptain = Random.Range(10, 21);
        captainAmerica.ThrowShield();
        ironMan.TakeDamage(damageCaptain);
       
    }
}
