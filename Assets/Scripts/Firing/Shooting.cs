using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour {

	public Texture2D bullet;
	public Transform objectLocation;

	void Start() {
		objectLocation = gameObject.transform;
	}
 

	// Update is called once per frame
	void Update () {
		if (Input.GetButton("Fire1")){
			Instantiate(bullet, objectLocation);
		}
	}
}
