﻿//written by: Sam williams 
//email: swilliams9uon.edu.au
//project: Assignment 3 - inft3960

using UnityEngine;
using UnityEngine.UI;

public class UpdateUI : MonoBehaviour
{    
    //class variables
    private int pizzaCount = 0;
    private Text pizzaText;
    void Update()
    {
        pizzaCount = gameObject.GetComponentInParent<PlayerMovement>().PizzaCount;
        pizzaText = gameObject.transform.Find("PizzaText").gameObject.GetComponentInChildren<Text>();
        pizzaText.text = "Pizza Count: "+ pizzaCount;    
    }
    
    
}
