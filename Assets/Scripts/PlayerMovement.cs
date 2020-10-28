//written by: Sam williams 
//email: swilliams9uon.edu.au
//project: Assignment 2 - inft3960

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public CharacterController2D myController;
    public Animator animator;

    public float Xmove = 0f;
    public bool Ollie = false;
    public int PizzaCount = 0;
    public int DeathCount = 0;
    public int Ammo = 5;


    // Update is called once per frame
    void Update()
    {
        
        Xmove = Input.GetAxisRaw("Horizontal")*40f;

        if (Input.GetButtonDown("Jump"))
        {
            Ollie = true;
            animator.SetBool("IsJumping", true); 
        }
 

        
    }

    void FixedUpdate()
    {
        myController.Move(Xmove*Time.fixedDeltaTime, Ollie);
        Ollie = false;
    }

    public void onLanding()
    {
        Debug.Log("ON LANDING() TRIGGERED");
        animator.SetBool("IsJumping", false);
    }
}
