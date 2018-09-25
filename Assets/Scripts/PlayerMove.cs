using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour {

    private Rigidbody2D rb;
    public float speed;
    private bool touching;
    private float jumptime;
    private const float AirTime = 0.2f;
    private bool spaceAllowed = false;
    private bool spaceLast = false;

	void Start () {
        rb = gameObject.GetComponent<Rigidbody2D>();
        jumptime = 0;
        touching = true;
    }

    public void OnTriggerEnter2D(Collider2D c)
    {
        if (c.gameObject.tag == "collider")
        {
            touching = true;
        }
    }

    public void OnTriggerExit2D(Collider2D c)
    {
        if (c.gameObject.tag == "collider"){
            touching = false;
        }
    }


    void FixedUpdate () {

        if (touching)
        {
            spaceAllowed = !spaceLast;
            spaceLast = Input.GetKey(KeyCode.Space);
        }

        if (Input.GetKey(KeyCode.Space))
        {

            if ((touching || AirTime >= Time.time - jumptime) && spaceAllowed)
            {
                rb.AddForce(new Vector2(0f, 3.5f), ForceMode2D.Impulse);
                if (touching){
                    jumptime = Time.time;

                }
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
