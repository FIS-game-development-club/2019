using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClassContainer : MonoBehaviour {

	public static GameClass rogue;
	public static GameClass warrior;
	public static GameClass ranger;
	public static GameClass mage;

	// Use this for initialization
	void Start () {
		rogue = new GameClass("rogue", new List<Weapon>(), new StatSet("Scripts/Classes/rogue.stat"));
        warrior = new GameClass("warrior", new List<Weapon>(), new StatSet("Scripts/Classes/warrior.stat"));
        ranger = new GameClass("ranger", new List<Weapon>(), new StatSet("Scripts/Classes/ranger.stat"));
		mage = new GameClass("mage", new List<Weapon>(), new StatSet("Scripts/Classes/mage.stat"));
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
