using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof (Controller2D))] 
public class Player : MonoBehaviour {

    #region

    public float moveSpeed = -3; // Movement speed for ploppy
    Vector2 velocity; // Used to determine proper speed for player, this way it can be affected by more things than movespeed later on
    public int poopLeft = 3; // Number of poops left
    bool poopGone; //check if poop is all gone

    Controller2D controller;
    #endregion

    // Use this for initialization
    void Start () {
        controller = GetComponent<Controller2D>();

	}
	
	// Update is called once per frame
	void Update () {
        velocity.x = -moveSpeed;
        if (poopGone)
            velocity.y = moveSpeed;
        else
            velocity.y = 0;

        controller.Move(velocity * Time.deltaTime);
	}
}
