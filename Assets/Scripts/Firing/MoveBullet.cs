using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBullet : MonoBehaviour {

	public float bulletSpeed;
    
	void OnCollisionEnter2D(Collision2D c) {
		Destroy(gameObject);
	}

	void FixedUpdate () {
		transform.Translate(Vector2.right * Time.deltaTime * bulletSpeed);
	}
}