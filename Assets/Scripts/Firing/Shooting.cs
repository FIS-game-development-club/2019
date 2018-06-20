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
		
 

	// Update is called once per frame
	void Update () {
		if (Input.GetButton("Fire1")) {
			Instantiate(bullet, objectLocation.position, objectLocation.rotation);	
		}
	}
}
