//written by: Sam williams 
//email: swilliams9uon.edu.au
//project: Assignment 2 - inft3960

using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;
using System.Collections.Generic;
public class ThadController : MonoBehaviour
{    
    public float speed;
    private Transform target;

    
    void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }

    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, target.position, speed*Time.deltaTime);
    }
    
    
}
