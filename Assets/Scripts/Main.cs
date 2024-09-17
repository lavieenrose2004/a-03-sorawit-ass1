using Unity.VisualScripting;
using UnityEngine;

public class Main : MonoBehaviour
{
    public IronMan ironman;
    public CaptainAmerica captainamerica;
    int round = 0;

    // Start is called before the first frame update
    void Start()
    {
       
        Debug.Log("====== Battle Begins ======");

    }

    private void Update()
    {
        if(ironman.IsDead() || captainamerica.IsDead())
        {
            
            return;
        }

        Debug.Log($"Round {round+ 1}");

        // IronMan attacks Captain America
        int damageIronMan = Random.Range(10, 21);
        ironman.ShootLaser();
        captainamerica.TakeDamage(damageIronMan);
        

        // Captain America attacks IronMan
        int damageCaptain = Random.Range(10, 21);
        captainamerica.ThrowShield();
        ironman.TakeDamage(damageCaptain);
        Debug.Log($"Round {round++}");
        
    }
}
