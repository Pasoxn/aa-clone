﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pin : MonoBehaviour {

    private bool isPinned = false; //setting up the pin's natural state as not attatched to the big circle 

    public float speed = 20f; //allows the speed to be set, float because movement is involved
    public Rigidbody2D rb; //making sure the rigidbody is there to interact with 

    void Update()
    {
        if(!isPinned) //if it isn't false...(enter thing that happens)
        rb.MovePosition(rb.position + Vector2.up * speed * Time.deltaTime); //moving the rigidbody, take the coordinates (x,y) and modifying it, coordinates + z speed and just time.deltatime cause speed 
    }



    void OnTriggerEnter2D(Collider2D col)
    {
       if (col.tag == "Rotator") //naming the collider TAG as the rotator 
        {
            transform.SetParent(col.transform);
            //col.GetComponent<Rotator>().speed += 20f; every time the pin hits, the rotator goes faster 
            //col.GetComponent<Rotator>().speed *= -1  rotator rotates the opposite way when a pin is stuck into the middle 
            isPinned = true; //when it is true, what happens?

        } else if (col.tag == "Pin")
        {
            //end game 
            // to test if the code above works: Debug.Log("you hit something");
            FindObjectOfType<GameManager>().EndGame();

        }
    }
}



   