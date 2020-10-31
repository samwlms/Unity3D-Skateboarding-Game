//written by: Sam williams 
//email: swilliams9uon.edu.au
//project: Assignment 2 - inft3960

using UnityEngine;

public class VehincleController : MonoBehaviour
{
    //set the speed the vehicle will travel
    public float Speed = 0.005f;

    void Update()
    {
        //Move the vehicle along a set X-axis path
        gameObject.transform.position += new Vector3(-Speed* Time.deltaTime,0f,0f); //delatTime normalises speed across systems
    }
    
    void OnCollisionEnter2D(Collision2D col)
    {
        //if the vehicle collides with the deadzone...
        if(col.transform.CompareTag("DeadZone"))
        {
            //inverse the speed
            Speed = -Speed;
            //flip vehicle horizontally
            Vector3 theScale = transform.localScale;
		    theScale.x *= -1;
		    transform.localScale = theScale;
        }
    }
}
