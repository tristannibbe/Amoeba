using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenericEnemyController : MonoBehaviour
{
    public float damage;
    public float health;

    private StatsSystem enemyStats;

    // Start is called before the first frame update
    void Start()
    {
        enemyStats = new StatsSystem(health,damage);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void takeDamage(float amount)
    {
        bool dead = enemyStats.takeDamage(amount);
        print("damaged for " + amount);


        if (dead)
        {
            gameObject.SetActive(false);
        }
    }
}
