using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AimWeapon : MonoBehaviour {

	private Vector3 mousePosition;
	private Vector2 direction;
	private SpriteRenderer parentSprite;
	private SpriteRenderer weaponSprite;

	void Start(){
		parentSprite = transform.parent.gameObject.GetComponent<SpriteRenderer>();
		weaponSprite = gameObject.GetComponent<SpriteRenderer>();
	}

	void Update(){
		mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);

		direction = new Vector2(
			mousePosition.x - transform.position.x,
			mousePosition.y - transform.position.y
		);
		parentSprite.flipX = (mousePosition.x < transform.position.x);
		weaponSprite.flipY = (mousePosition.x < transform.position.x);
		transform.right = direction;
	}
}