﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour {

    private bool collide = false;
    private  int colliderY;
    private int colliderX;
    private GameObject player;
    public float speed;

    void Start (){
        player = GameObject.FindWithTag("player");
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
            if (player.transform.position.x > transform.position.x)
            {
                transform.Translate(Vector2.right * ((float)(player.transform.position.x - transform.position.x - colliderX)) * speed);
            }
            if (player.transform.position.x < transform.position.x)
            {
                transform.Translate(Vector2.left * ((float)(transform.position.x - colliderX - player.transform.position.x)) * speed);
            }
            if (player.transform.position.y > transform.position.y)
            {
                transform.Translate(Vector2.up * ((float)(player.transform.position.y - transform.position.y - colliderY)) * speed);
            }
            if (player.transform.position.y < transform.position.y)
            {
                transform.Translate(Vector2.down * ((float)(transform.position.y - colliderY - player.transform.position.y)) * speed);
            }
        }
	}
}
