using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;

public class Player : MonoBehaviour
{
    //this is the player stats 
    public int playerHealth = 10;
    public int playerLevel = 1;
    public int playerAttack;
    public int playerXp = 0;
    public int xpThreshold = 10;
    public int heavyAttack;
    public int hitsToChargeHeavyAttack = 2;
    // Start is called before the first frame update
    void Start()
    {
        //this makes sure the player attack is acc to the player level
        playerAttack = (int)(playerLevel * 0.25f + 1);

    }

    private void Update()
    {
        //This checks if the player has reached the xp limit and runs the level up function

        if (playerXp >= xpThreshold)
        {
            LevelUp();
            //makes sure the overflow xp isnt lost
            playerXp = playerXp - xpThreshold;
        }
    }

    public void LevelUp()
    {
        //This increases the player's level by 1
        playerLevel++;
        Debug.Log("Hooray! You're now a level"+ playerLevel+ "explorer");
        //increases the xp threshold by 10.
        xpThreshold += 10;

    }
}
   
   



