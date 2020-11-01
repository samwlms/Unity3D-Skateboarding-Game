//written by: Sam williams 
//email: swilliams9uon.edu.au
//project: Assignment 3 - inft3960

using UnityEngine;

public class CollectablePizza : MonoBehaviour
{
    public AudioClip clip;
    private bool grow = true;
    private Vector3 growRate = new Vector3(0.0005f, 0.0005f, 0f);
    private float volume = 2f;
    private GlobalVariables globalVars;
    void Start()
    {
        globalVars = FindObjectOfType<GlobalVariables>();
    }

    // Update is called once per frame
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
            AudioSource.PlayClipAtPoint(clip, transform.position, volume);
            col.gameObject.GetComponent<PlayerMovement>().PizzaCount++;
            Destroy(gameObject);
        }
    }
}
