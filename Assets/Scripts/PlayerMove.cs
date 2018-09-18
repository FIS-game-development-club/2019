using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour {

    Rigidbody2D rb;
    public float speed;

	void Start () {
        rb = gameObject.GetComponent<Rigidbody2D>();
	}
	
	void FixedUpdate () {
		
        if(Input.GetKey(KeyCode.Space))
        {

        }

        if (Input.GetKey(KeyCode.A))
        {

        }

        if (Input.GetKey(KeyCode.D))
        {
            print("yeet");
            rb.AddForce(new Vector2(speed, 0.0f), ForceMode2D.Impulse);
        }
    }
}
