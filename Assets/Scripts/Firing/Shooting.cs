using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour {

	public GameObject bullet;
	private Transform objectLocation;
	public GameObject instantiateLocation;


	void Start() {
		objectLocation = instantiateLocation.transform;
		
	}
		
 	void Update () {
		if (Input.GetButtonDown("Fire1")) {
			Instantiate(bullet, objectLocation.position, objectLocation.rotation);	
		}
	}
}
