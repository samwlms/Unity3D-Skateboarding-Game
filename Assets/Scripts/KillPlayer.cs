//written by: Sam williams 
//email: swilliams9uon.edu.au
//project: Assignment 3 - inft3960

using UnityEngine;

public class KillPlayer : MonoBehaviour
{
    //set the spawn point to return the player to
    [SerializeField] Transform SpawnPoint;

    private GlobalVariables globalVars;
    void Start()
    {
        globalVars = FindObjectOfType<GlobalVariables>();
    }


    void OnCollisionEnter2D(Collision2D col)
    {
        //if player collides with 'killplayer' gameobject..
        if (col.transform.CompareTag("Player"))
        {
            //move the payer back to the spawn point
            col.transform.position = SpawnPoint.position;
            //add a death to the global variables counter in the persistent gameobject
            globalVars.deaths++;
        }
    }

}
