using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBullet : MonoBehaviour {

	public float bulletSpeed;
    public GameObject ShotBy;
    
    void OnTriggerEnter2D(Collider2D c) {
        if (c.gameObject != ShotBy)
        {
            Destroy(gameObject);
        }
	}

	void FixedUpdate () {
		transform.Translate(Vector2.right * Time.deltaTime * bulletSpeed);
	}
}