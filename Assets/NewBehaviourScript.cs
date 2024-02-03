//----------------------------------------------------
//NAMESPACES
//test explanation
//NAMESPACE SECTION
//This section is not code, the top section is explanations to make things easier for the normal person to understand
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//----------------------------------------------------


//CLASS DECLARATION
//"NewBehaviour Script" is just the name of the script
//Monobehaviour says it can do Unity stuff
//{} hold the contents of something(beginining and end)
//void means'making a function'
// Start is just the name of the function
//()have to put these after the function name
//{} braces hold the contents of the function
//Use this for initizalzation 
public class NewBehaviourScript : MonoBehaviour {

    // Start is called before the first frame update
    void Start () {
          //print out a message at the beginning of the game
          print("this is the start");
         //call the Eat function 
         Eat();
    }

    // Update is called once per frame
    void Update () {
        print("This is an update");  
    }

    //custom function
    void Eat() {
        print("chew the food");
        print("swallow the food");
        print("digest the food");
        print("...");
    }

}    //-------------------------------------------------
    //DON'T TOUCH THIS BRACE
    //-------------------------------------------------

