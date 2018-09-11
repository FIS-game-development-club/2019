using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour {
	public float speed;
	public float jumpPower;
	public float jumpdelay;
	private float jumptime;
	private Rigidbody2D rb;
	private bool collide = false;
	
	PlayerStats data;

	void Start(){
		rb = gameObject.GetComponent<Rigidbody2D>();
		jumptime = jumpdelay;
		data = gameObject.GetComponent<PlayerStats>();
	}

	void OnTriggerExit2D(Collider2D c){
        if (c.tag != "MainCamera")
        {
            collide = false;
            jumptime = Time.time;
        }
	}

	void OnTriggerEnter2D(Collider2D c){
        if (c.tag != "MainCamera")
        {
            collide = true;
        }
	}


	void FixedUpdate () {
		if(Input.GetKey(KeyCode.D)){
			if(collide || Time.time - jumptime < jumpdelay * 2){
				rb.AddForce(Vector2.right * speed, ForceMode2D.Impulse);
			}
		}
		if(Input.GetKey(KeyCode.A)){
			if(collide || Time.time - jumptime < jumpdelay * 2){
				rb.AddForce(Vector2.left * speed, ForceMode2D.Impulse);
			}
		}

        if(Input.GetKey(KeyCode.Space) || Input.GetKey(KeyCode.W)){
			if(collide || Time.time - jumptime < jumpdelay){
				rb.AddForce(Vector2.up * jumpPower, ForceMode2D.Impulse);
			}
		}
	}
}
