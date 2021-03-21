using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenericEnemyController : MonoBehaviour
{
    public float damage;
    public float health;
    public GameObject player;
    public float moveSpeed;

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

    private void FixedUpdate()
    {
        if (player)
        {
            transform.position = Vector2.MoveTowards(transform.position,player.transform.position,moveSpeed);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        PlayerController player = collision.GetComponent<PlayerController>();


        if (player)
        {
            player.takeDamage(enemyStats.getDamage());
        }
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
