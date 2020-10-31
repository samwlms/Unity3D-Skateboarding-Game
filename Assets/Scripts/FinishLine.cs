//written by: Sam williams 
//email: swilliams9uon.edu.au
//project: Assignment 3 - inft3960

using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishLine : MonoBehaviour
{
    //set index of the scene the finish line will move to
    public int IndexOfLevelEndScene;
    void OnCollisionEnter2D(Collision2D col)
    {
        //If the player has collided with the finish line...
        if(col.transform.CompareTag("Player"))
        {
            //load the user-defined scene
            SceneManager.LoadScene(IndexOfLevelEndScene);
        }
    }
    
}
