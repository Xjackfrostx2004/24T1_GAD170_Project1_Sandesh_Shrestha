using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    //this is the enemy stats 
    public int enemyHealth;
    public int enemyLevel;
    public int enemyAttack;

    // Start is called before the first frame update
    void Start()
    {
        enemyLevel = Random.Range(1, 10);
        //this makes sure the enemy attack is acc to the player level
        enemyAttack = (int)(enemyLevel * 0.5f + .5f);
        enemyHealth = enemyLevel * 2;
    }
}
