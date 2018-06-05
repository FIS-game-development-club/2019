using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBullet : MonoBehaviour {

	public float bulletSpeed;

	private Rigidbody2D bulletRb;
	
	void Awake() {
		bulletRb = gameObject.GetComponent<Rigidbody2D>();
	}

	// Update is called once per frame
	void Start () {
		bulletRb.AddForce(Vector2.right * bulletSpeed, ForceMode2D.Impulse);
	}
}
