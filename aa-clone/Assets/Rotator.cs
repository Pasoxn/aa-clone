using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{

    public float speed = 100f; //setting speed as a variable that has something to do with movement

    void Update()
    {
        transform.Rotate(0f, 0f, speed * Time.deltaTime); //rotates by degrees, 0x, 0y, and z is the speed that can be adjusted cause its a variable
        //Time.deltaTime makes it so that the game plays the same, no matter if the framerate is low or high
    }
}