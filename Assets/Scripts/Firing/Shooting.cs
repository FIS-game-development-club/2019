using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour {

	public GameObject bullet;
	private Transform objectLocation;
	public GameObject instantiateLocation;
	public GameObject instantiateLocation2;
	private SpriteRenderer sprite;



	void Start() {
		sprite = gameObject.GetComponent<SpriteRenderer>();
	}
		
 	void Update () {
		if (Input.GetButtonDown("Fire1")) {

		if(!sprite.flipY){
			objectLocation = instantiateLocation.transform;
		}

		else{
			objectLocation = instantiateLocation2.transform;
		}
			Instantiate(bullet, objectLocation.position, objectLocation.rotation);	
		}
	}
}
