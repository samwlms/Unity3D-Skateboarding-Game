//written by: Sam williams 
//email: swilliams9uon.edu.au
//project: Assignment 3 - inft3960

using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
using UnityEngine.UI;

//class used to figure out the next level based off the GlobalVars values
public class GetContext : MonoBehaviour
{
    public ButtonScript localInstance;
    void Start()
    {
        GlobalVariables globalVars = FindObjectOfType<GlobalVariables>();
        globalVars.CurrentLevel++;
        int currentLevel = globalVars.CurrentLevel;
        Debug.Log("The 'getContext' script has initialised");
        Debug.Log("The current level stored is: "+currentLevel);
        localInstance.SceneIndexToLoad = currentLevel;

    }

}
