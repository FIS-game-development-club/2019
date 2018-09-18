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
        cls = classes.GetField(className);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void TaskOnClick () {
		playerData.cls = cls;
        playerData.stats = cls.baseStats;
	}
}
