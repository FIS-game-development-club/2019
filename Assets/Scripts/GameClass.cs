public class GameClass {

    public string name;
    public List<Weapon> allowedWeapons;
    public StatSet baseStats;

    GameClass (string _name, List<Weapon> _allowedWeapons, StatSet _baseStats) {
        name = _name;
        allowedWeapons = _allowedWeapons;
        baseStats = _baseStats;
    }

}