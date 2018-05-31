using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {
	public float speed;
	public float jumpPower;
	public float jumpdelay;
	private float jumptime;
	private Rigidbody2D rb;
	private bool collide = false;
	
	void Start(){
		rb = gameObject.GetComponent<Rigidbody2D>();
		jumptime = jumpdelay;
	}

	void OnCollisionEnter2D(Collision2D c){
		if(c.gameObject.tag == "collider"){
			collide = true;
		}
	}

	void OnCollisionExit2D(Collision2D c){
		if(c.gameObject.tag == "collider"){
			collide = false;
			jumptime = Time.time;
		}
	}

	void FixedUpdate () {
		if(Input.GetKey(KeyCode.D)){
			if(collide || Time.time - jumptime < jumpdelay * 2.5){
				rb.AddForce(Vector2.right * speed, ForceMode2D.Impulse);
			}
		}
		if(Input.GetKey(KeyCode.A)){
			if(collide || Time.time - jumptime < jumpdelay * 2.5){
				rb.AddForce(Vector2.left * speed, ForceMode2D.Impulse);
			}
		}

		if(Input.GetKey(KeyCode.Space)){
			if(collide || Time.time - jumptime < jumpdelay){
				rb.AddForce(Vector2.up * jumpPower, ForceMode2D.Impulse);
			}
		}
	}
}
