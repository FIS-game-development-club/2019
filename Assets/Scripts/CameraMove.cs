using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour {

    private bool collide = false;
    private  int colliderY;
    private int colliderX;

    void Start (){
        
    }

    private void OnTriggerExit2D(Collider2D c)
    {
        if (c.tag == "player"){
            collide = true;
        }
    }

    private void OnTriggerEnter2D(Collider2D c)
    {
        if (c.tag == "player")
        {
            collide = false;
        }
    }

    void Update () {
        if(collide){
            
        }
	}
}
