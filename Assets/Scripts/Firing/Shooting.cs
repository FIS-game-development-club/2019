using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour {

	private Transform objectLocation;
	public GameObject instantiateLocation;
	public GameObject instantiateLocation2;
	private SpriteRenderer sprite;
    private float prevX;



	void Start() {
		sprite = gameObject.GetComponent<SpriteRenderer>();
	}
		
 	void FixedUpdate () {
		if (Input.GetButtonDown("Fire")) {

		    if(!sprite.flipY){
		        objectLocation = instantiateLocation.transform;
		    }

	        else{
			    objectLocation = instantiateLocation2.transform;
		    }

            MoveBullet obj = (Instantiate(Resources.Load("Bullet"), objectLocation.position, objectLocation.rotation) as GameObject).GetComponent<MoveBullet>();
            obj.bulletSpeed += (transform.position.x - prevX) * 10;
            obj.ShotBy = transform.root.gameObject;

		}
        prevX = transform.position.x;
	}
}
