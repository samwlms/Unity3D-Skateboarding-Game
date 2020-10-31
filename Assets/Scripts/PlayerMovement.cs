//written by: Sam williams 
//email: swilliams9uon.edu.au
//project: Assignment 3 - inft3960

using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public CharacterController2D myController;
    public Animator animator;

    public float Xmove = 0f;
    public bool Ollie = false;
    public int PizzaCount = 0;
    public int PlayerLives = 3;
    public int Ammo = 5;


    void Update()
    {

        Xmove = Input.GetAxisRaw("Horizontal") * 40f;

        if (Input.GetButtonDown("Jump"))
        {
            Ollie = true;
            animator.SetBool("IsJumping", true);
        }

    }

    void FixedUpdate()
    {
        myController.Move(Xmove * Time.fixedDeltaTime, Ollie);
        Ollie = false;
    }

    public void onLanding()
    {
        Debug.Log("ON LANDING() TRIGGERED");
        animator.SetBool("IsJumping", false);
    }
}
