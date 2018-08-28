using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour {

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
			Instantiate(Resources.Load("Bullet"), objectLocation.position, objectLocation.rotation);	
		}
	}
}
