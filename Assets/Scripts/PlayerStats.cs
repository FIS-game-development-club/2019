using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour {

    public ClassContainer classes;
    public GameClass cls;
    public StatSet stats;

    void Awake() {
       DontDestroyOnLoad(this.gameObject); 
    }

    void Start() {
        cls = classes.rogue;
        stats = cls.baseStats;
    }

    void Update() {
        print(stats.maxHealth);
    }
}