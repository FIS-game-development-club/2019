using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour {

    public ClassContainer classes;
    public GameClass cls;
    public StatSet stats;

    void Start() {
        cls = classes.rogue;
        print(cls);
        stats = cls.baseStats;
    }
}