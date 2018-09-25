using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClassContainer : MonoBehaviour {

	public GameClass rogue;
	public GameClass warrior;
	public GameClass ranger;
	public GameClass mage;

	// Use this for initialization
	void Awake () {
		rogue = new GameClass("rogue", new List<Weapon>(), new StatSet("Assets/Scripts/Classes/rogue.stat"));
		print(rogue);
        warrior = new GameClass("warrior", new List<Weapon>(), new StatSet("Assets/Scripts/Classes/warrior.stat"));
        ranger = new GameClass("ranger", new List<Weapon>(), new StatSet("Assets/Scripts/Classes/ranger.stat"));
		mage = new GameClass("mage", new List<Weapon>(), new StatSet("Assets/Scripts/Classes/mage.stat"));
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
