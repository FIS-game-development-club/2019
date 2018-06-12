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
	
	void Start(){
		rb = gameObject.GetComponent<Rigidbody2D>();
		jumptime = jumpdelay;
	}

	void OnTriggerExit2D(Collider2D c){
			collide = false;
			jumptime = Time.time;
			Debug.Log("not colliding");
	}

	void OnTriggerEnter2D(Collider2D c){
			collide = true;
			Debug.Log("colliding");
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
