//written by: Sam williams 
//email: swilliams9uon.edu.au
//project: Assignment 3 - inft3960

using UnityEngine;
using UnityEngine.SceneManagement;
public class ButtonScript : MonoBehaviour
{    
    //set the index (maps to build settings) of the scene to load by the button
    public int SceneIndexToLoad;
    void OnMouseDown() 
    {
        //load the user specified scene on button click
        SceneManager.LoadScene(SceneIndexToLoad);    
    }
}
