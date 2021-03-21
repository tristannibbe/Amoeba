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
        if (collision.gameObject.CompareTag("Enemy"))
        {
            float totalDamage = player.playerStats.getDamage() + Damage;
            collision.gameObject.GetComponent<GenericEnemyController>().takeDamage(totalDamage);
        }
    }
}
