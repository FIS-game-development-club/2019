using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour {

	public Texture2D bullet;
	// Update is called once per frame
	void Update () {
		if (Input.GetButton("Fire1")){
			Instantiate(bullet);
		}
	}
}
