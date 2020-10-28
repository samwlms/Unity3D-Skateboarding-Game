//written by: Sam williams 
//email: swilliams9uon.edu.au
//project: Assignment 2 - inft3960

using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;
public class UpdateUI : MonoBehaviour
{    
    private int pizzaCount = 0;
    private Text pizzaText;
    void Start()
    {

    }

    void Update()
    {
        pizzaCount = gameObject.GetComponentInParent<PlayerMovement>().PizzaCount;
        pizzaText = gameObject.transform.Find("PizzaText").gameObject.GetComponentInChildren<Text>();
        pizzaText.text = "Pizza Count: "+ pizzaCount;    
    }
    
    
}
