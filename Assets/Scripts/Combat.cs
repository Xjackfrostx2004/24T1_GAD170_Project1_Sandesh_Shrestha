using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Combat : MonoBehaviour
{
    // Start is called before the first frame update
    private void Start()
    {
        Debug.Log("Welcome to ZombieMania");
        Debug.Log("Press SPACEBAR to start the game");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("You're in a dark dungeon, Use the mouse buttons to ");
        }

        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            Debug.Log("You've moved left ");
        }

        if (Input.GetKeyDown(KeyCode.Mouse1))
        {
            Debug.Log("You've moved right ");
        }


    }
   
}
