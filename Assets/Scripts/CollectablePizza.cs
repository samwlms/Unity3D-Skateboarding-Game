//written by: Sam williams 
//email: swilliams9uon.edu.au
//project: Assignment 3 - inft3960

using UnityEngine;

public class CollectablePizza : MonoBehaviour
{
    public AudioClip clip;
    private float volume = 2f;
    private GlobalVariables globalVars;

    //the following 2 variables handle the dynamic animation of the pizza
    private bool grow = true;
    private Vector3 growRate = new Vector3(0.0005f, 0.0005f, 0f);
    void Start()
    {
        globalVars = FindObjectOfType<GlobalVariables>();
    }

    void Update()
    {

        if (grow)
        {
            gameObject.transform.localScale += growRate;
            if (gameObject.transform.localScale.x > .5f)
            {
                grow = false;
            }

        }
        else
        {
            gameObject.transform.localScale -= growRate;
            if (gameObject.transform.localScale.x < .3f)
            {
                grow = true;
            }
        }
    }


    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.transform.CompareTag("Player"))
        {
            Destroy(gameObject);
            
            //play the audio file associated with the pizza
            AudioSource.PlayClipAtPoint(clip, transform.position, volume);

            //add to the count of the level specific pizza counter (not global or persistant)
            col.gameObject.GetComponent<PlayerMovement>().PizzaCount++;


            //add a pizza to the global variables counter in the persistent gameobject
            globalVars.pizzas++;

        }
    }
}
