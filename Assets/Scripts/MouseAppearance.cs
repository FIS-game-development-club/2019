using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseAppearance : MonoBehaviour {


	public Texture2D defaultMouse;
	public CursorMode curMode = CursorMode.Auto;
	public Vector2 hotspot = Vector2.zero;

	// Use this for initialization
	void Start () {
		Cursor.SetCursor(defaultMouse, hotspot, curMode);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
