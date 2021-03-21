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

    public bool takeDamage(float amount)
    {
        bool dead = false;
        this.currHealth -= amount;

        if (currHealth <= 0)
        {
            dead = true;
        }

        return dead;

    }

    public void setHealth(float health)
    {
        this.currHealth = health;
        
        if(currHealth > maxHealth)
        {
            currHealth = maxHealth;
        }


    }

}

