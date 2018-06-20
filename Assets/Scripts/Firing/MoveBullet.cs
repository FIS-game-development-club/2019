﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBullet : MonoBehaviour {

	public float bulletSpeed;

	private Rigidbody2D bulletRb;

	void OnTriggerEnter2D(Collider2D c) {
		Destroy(gameObject);
	}

	void FixedUpdate () {
		transform.Translate(Vector2.right * Time.deltaTime * bulletSpeed);
	}
}
