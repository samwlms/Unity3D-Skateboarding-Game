using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectablePizza : MonoBehaviour
{
    public AudioClip clip;
    private bool grow = true;
    private Vector3 growRate = new Vector3(0.0005f,0.0005f,0f);
    private float volume = 2f;


    // Update is called once per frame
    void Update()
    {

        if (grow)
        {
            gameObject.transform.localScale += growRate;
            if(gameObject.transform.localScale.x > .5f)
            {
                grow = false;
            }

        }
        else
        {
            gameObject.transform.localScale -= growRate;
            if(gameObject.transform.localScale.x < .3f)
            {
                grow = true;
            }
        }
    }


    void OnCollisionEnter2D(Collision2D col)
    {
        if(col.transform.CompareTag("Player"))
        {
            AudioSource.PlayClipAtPoint(clip, transform.position, volume);
            col.gameObject.GetComponent<PlayerMovement>().PizzaCount++;
            Destroy(gameObject);
        }
    }
}
