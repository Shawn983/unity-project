using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript1 : MonoBehaviour {
//-------------------------

   
    //Put Type of variable first (what type of data will be stored)
    //put NAME of variable next (what you want to call it)
    //----------------
    //Variables
    //---------------------------
    public float moveSpeed;
    //---------------------------
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update() {
        //MOVE OBJECT, SMALl teleportions every frame
        transform.Translate(Vector3.right * moveSpeed);
    }
}   //DONT TOUCH THIS BRACE
    //---------------------
