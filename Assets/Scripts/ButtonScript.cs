//written by: Sam williams 
//email: swilliams9uon.edu.au
//project: Assignment 2 - inft3960

using UnityEngine;
using UnityEngine.SceneManagement;
public class ButtonScript : MonoBehaviour
{    
    public int SceneIndexToLoad;
    void OnMouseDown() 
    {
        SceneManager.LoadScene(SceneIndexToLoad);    
    }
}
