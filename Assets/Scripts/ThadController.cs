//written by: Sam williams 
//email: swilliams9uon.edu.au
//project: Assignment 3 - inft3960

using UnityEngine;

public class ThadController : MonoBehaviour
{
    //Class variables
    public float speed;
    public GameObject skater;
    private Transform dest;
    Renderer camera_view;
    void Start()
    {
        //set the destination position of Thad based off current user position
        dest = skater.GetComponent<Transform>();
        //camera_view variable defines current screen space being rendered
        camera_view = GetComponent<Renderer>();
    }

    void Update()
    {
        //check to see if Thad is currently visible on screen
        if (camera_view.isVisible)
        {
            //if he is, move towards the skater at user defined speed coefficent
            transform.position = Vector2.MoveTowards(transform.position, dest.position, speed * Time.deltaTime);

        }
    }


}
