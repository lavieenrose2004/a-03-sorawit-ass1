using UnityEngine;

public class Main : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        IronMan ironMan = new IronMan("Tony Stark", 100, "Red");
        CaptainAmerica captainAmerica = new CaptainAmerica("Steve Rogers", 100, "Blue");

        Debug.Log("====== Battle Begins ======");

        for (int i = 0; i < 5; i++)
        {
            // IronMan attacks Captain America
            int damageIronMan = Random.Range(10, 21);
            ironMan.ShootLaser();
            captainAmerica.TakeDamage(damageIronMan);
            if (captainAmerica.IsDead()) break;

            // Captain America attacks IronMan
            int damageCaptain = Random.Range(10, 21);
            captainAmerica.ThrowShield();
            ironMan.TakeDamage(damageCaptain);
            if (ironMan.IsDead()) break;
        }
    }
}
