using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseAppearance : MonoBehaviour {

	//put the mouse texture in this public variable in the editor
	public Texture2D defaultMouse;
	//really doesn't matter what there are, just defaults
	public CursorMode curMode = CursorMode.Auto;
	public Vector2 hotspot = Vector2.zero;

	// Use this for initialization
	void Start () {
		//setting the cursor to our new mouse texture
		Cursor.SetCursor(defaultMouse, hotspot, curMode);
	}
}
