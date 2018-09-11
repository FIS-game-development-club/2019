using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour {

    public GameClass cls;
    public StatSet stats;

    void Start() {
        stats = cls.baseStats;
    }
}