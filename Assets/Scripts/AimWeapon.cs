using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AimWeapon : MonoBehaviour {

	private Camera camera;

	void Start(){
		camera = GameObject.FindWithTag("MainCamera").GetComponent<Camera>();
	}

	void Update () {
		Vector3 mouseLocation = camera.ScreenToWorldPoint(Input.mousePosition);
		mouseLocation.z = 0;
		transform.LookAt(mouseLocation);
	}
}
