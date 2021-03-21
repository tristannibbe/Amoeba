using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenericEnemyController : MonoBehaviour
{
    private StatsSystem enemyStats;

    // Start is called before the first frame update
    void Start()
    {
        enemyStats = new StatsSystem();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
