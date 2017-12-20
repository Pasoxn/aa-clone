using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

    private bool gameHasEnded = false;

    //saying that these two things exist in the first place, drag and drop in inspector 
    public Rotator rotator;
    public Spawner spawner;

    //need to define this when an animation has to be played 
    public Animator animator; 

    //what happens during the end of the game 
    public void EndGame ()
    {
        if (gameHasEnded)
            return;


        //when the game ends, these two things are disabled
        rotator.enabled = false;
        spawner.enabled = false;

        animator.SetTrigger("EndGame");

        //if gameHasEnded = true, then display the debug.log
        gameHasEnded = true; 
    }


}
