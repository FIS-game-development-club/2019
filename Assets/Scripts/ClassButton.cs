using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClassButton : MonoBehaviour {

	public string className;
	public GameClass cls;
	public ClassContainer classes;
	public PlayerStats playerData; 

	// Use this for initialization
	void Start () {
        cls = (GameClass)(classes.GetType().GetField(className).GetValue(classes));
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void TaskOnClick () {
		playerData.cls = cls;
		playerData.stats = cls.baseStats;
		print(playerData);
	}
}
