//written by: Sam williams 
//email: swilliams9uon.edu.au
//project: Assignment 3 - inft3960

using UnityEngine;
using UnityEngine.SceneManagement;

//class used to hold variables that will be used by subsequent scenes
//values are updated upon finishing the level via the finishLine.cs script associated with the 'finish line' gameobject
public class GlobalVariables : MonoBehaviour
{
   public int CurrentLevel = 2;
   void Start()
   {
       GameObject.DontDestroyOnLoad(this.gameObject);
   }
    
}
