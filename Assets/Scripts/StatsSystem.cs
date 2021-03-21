using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StatsSystem
{
    private float maxHealth;
    private float currHealth;
    private float damage;

    public StatsSystem(float health,float damage)
    {
        setMaxHealth(health);
        setHealth(health);
        setDamage(damage);
    }

    public float getDamage()
    {
        return damage;
    }

    public float getMaxHealth()
    {
        return maxHealth;
    }

    public float getCurrHealth()
    {
        return currHealth;
    }

    public void setDamage(float damage)
    {
        this.damage = damage;
    }

    public void setMaxHealth(float maxHealth)
    {
        this.maxHealth = maxHealth;
    }

    public bool setHealth(float health)
    {
        bool dead = false;
        this.currHealth = health;
        
        if(currHealth > maxHealth)
        {
            currHealth = maxHealth;
        }

        if(currHealth <= 0)
        {
            dead = true;
        }

        return dead;
    }

}

