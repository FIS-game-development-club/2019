using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour {

    private Rigidbody2D rb;
    public float speed;
    private bool touching;
    private float jumptime;
    public float AirTime;


	void Start () {
        rb = gameObject.GetComponent<Rigidbody2D>();
	}

    private void OnTriggerEnter2D(Collider2D c)
    {
        if (c.tag == "collider")
        {
            touching = true;
        }
    }

    private void OnTriggerExit2D(Collider2D c)
    {
        if(c.tag == "collider"){
            touching = false;
        }
        jumptime = Time.time;
    }


    void FixedUpdate () {
		
        if(Input.GetKey(KeyCode.Space))
        {
            if (touching )
            {
                rb.AddForce(new Vector2(0f, speed / 4), ForceMode2D.Impulse);
            }
        }

        if (Input.GetKey(KeyCode.A))
        {
            rb.AddForce(new Vector2(-speed, 0f), ForceMode2D.Impulse);
        }

        if (Input.GetKey(KeyCode.D))
        {
            rb.AddForce(new Vector2(speed, 0f), ForceMode2D.Impulse);
        }
    }
}
