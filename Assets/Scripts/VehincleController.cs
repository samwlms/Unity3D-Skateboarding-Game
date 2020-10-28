//written by: Sam williams 
//email: swilliams9uon.edu.au
//project: Assignment 2 - inft3960

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VehincleController : MonoBehaviour
{
    public float Speed = 0.005f;

    void Update()
    {
        gameObject.transform.position += new Vector3(-Speed,0f,0f);
    }
    
    void OnCollisionEnter2D(Collision2D col)
    {
        if(col.transform.CompareTag("DeadZone"))
        {
            Speed = -Speed;
            Vector3 theScale = transform.localScale;
		    theScale.x *= -1;
		    transform.localScale = theScale;
        }
    }
}
