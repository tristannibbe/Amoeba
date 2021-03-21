using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerWeaponController : MonoBehaviour
{
    public float Damage;

    PlayerController player;
 
    private void Start()
    {
        player = GetComponentInParent<PlayerController>();

    }


    private void OnTriggerEnter2D(Collider2D collision)
    {

        GenericEnemyController enemy = collision.gameObject.GetComponent<GenericEnemyController>();
        print("hit something");
        if (enemy)
        {
            float totalDamage = player.playerStats.getDamage() + Damage;
            enemy.takeDamage(totalDamage);
            print("attacked for " + totalDamage);
        }
    }
}
