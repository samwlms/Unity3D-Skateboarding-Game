//written by: Sam williams 
//email: swilliams9uon.edu.au
//project: Assignment 3 - inft3960

using UnityEngine;
using UnityEngine.UI;

//Script used to calculate thefinal scores at the end of the level
public class GetScores : MonoBehaviour
{
    private GlobalVariables globalVars;
    private Text pizzaText;
    private Text deathText;
    void Start()
    {
        globalVars = FindObjectOfType<GlobalVariables>();

        pizzaText = gameObject.transform.Find("pizzas").gameObject.GetComponentInChildren<Text>();
        pizzaText.text = globalVars.pizzas.ToString()+"/12";

        deathText = gameObject.transform.Find("deaths").gameObject.GetComponentInChildren<Text>();
        deathText.text = globalVars.deaths.ToString();
    }
}
