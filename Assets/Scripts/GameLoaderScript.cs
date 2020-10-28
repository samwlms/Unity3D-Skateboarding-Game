//written by: Sam williams 
//email: swilliams9uon.edu.au
//project: Assignment 2 - inft3960

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameLoaderScript : MonoBehaviour
{
    public Animator transition;
    public float waitTime = 1f;
    public int levelToLoad = 0;    

    // Update is called once per frame
    void Update()
    {
        //note: current implementation simply uses a click for the sake of simplicity,
        //- further buttons/ functionailty are to be added
        if(Input.GetMouseButtonDown(0))
        {
            LoadGame();
        } 
    }

    public void LoadGame()
    {
        StartCoroutine(LoadLevel(levelToLoad));
    }

    //-------------------------------------------------------
    //NOTE: the following coroutine delay functionality, while written by me,
    // heavily mirrors an example provided at 'https://youtu.be/CE9VOZivb3I'
    //-------------------------------------------------------
    IEnumerator LoadLevel(int levelIndex)
    {
        Scene current = SceneManager.GetActiveScene();
        if (current.name != "GameScene")
        {
            transition.SetTrigger("Start");
            yield return new WaitForSeconds(waitTime);
            SceneManager.LoadScene(levelIndex);
        }
        
    }
}
