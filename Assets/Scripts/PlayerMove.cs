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
            rb.AddForce(Vector2.right * speed);
        }
    }
}
