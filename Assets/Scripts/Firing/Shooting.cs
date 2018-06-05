using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour {

	public GameObject bullet;
	public Transform objectLocation;

	private Rigidbody2D bulletrb;

	public float bulletSpeed;

	void Start() {
		objectLocation = gameObject.transform;
		bulletrb = gameObject.GetComponent<Rigidbody2D>();
	}
		
 

	// Update is called once per frame
	void Update () {
		if (Input.GetButtonDown("Fire1")) {
			Instantiate(bullet, objectLocation.position, objectLocation.rotation);
			bulletrb.AddForce(Vector2.right * bulletSpeed);
		}
	}
}
