using System.Collections;
using System.Collections.Generic;
public class GameClass {

    public string name;
    public IList<Weapon> allowedWeapons;
    public StatSet baseStats;

    public GameClass (string _name, List<Weapon> _allowedWeapons, StatSet _baseStats) {
        name = _name;
        allowedWeapons = _allowedWeapons;
        baseStats = _baseStats;
    }

}