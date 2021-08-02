using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StackCode : MonoBehaviour

//using stack - LIFO (Last In, First Out) 

{
    private Stack<string> effects = new Stack<string>(); //STACKED type of data structure lol 

    public Text display; //displays text

    private float timer = 0; //var that keeps track of how much time went by
    private float timePerTurn = 5; //var that shows amnt of time before stop

    private void Start()
    {
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) //if you press down space 
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex); //basically enables reload of scene (BUT FAST)
        }
        
        if (timer > timePerTurn) return;  // If a move takes more than 5 seconds then continue
        //return is basically a nifty lil shortcut
        
        timer += Time.deltaTime; //increasing timer 
        
        if (Input.GetKeyDown(KeyCode.A)) //if you press a 
        {
            effects.Push("you pressed a"); //get this effect
        }
        if (Input.GetKeyDown(KeyCode.S)) //if you press s 
        {
            effects.Push("you pressed s"); //get this effect
        }
        if (Input.GetKeyDown(KeyCode.D)) //if you press d 
        {
            effects.Push("you pressed d"); //get this effect
        }
        if (Input.GetKeyDown(KeyCode.F)) //if u press f 
        {
            effects.Push("you pressed f"); //get this effect
        }
        
        if (timer >= timePerTurn) //if the timer is up 
        {
            display.text = "here's what u pressed\n"; //display this text

            ShowStackEffects(); //show the effects of the keys u pressed
        }
        else //OTHERWISE........
        {
            display.text = (timePerTurn - timer).ToString("F2"); //display timer (F2 shows 2 digits on timer, makes it clean)
        }
    }

    private void ShowStackEffects() //a function that allows u to show stack effects
    {
        while (effects.Count > 0) //if effects is greater than 0 
            display.text += "\n" + effects.Pop(); //display!!
    }
}
