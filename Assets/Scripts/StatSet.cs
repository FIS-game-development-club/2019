public class StatSet {

    public float maxHealth;
    public float maxMana;
    public float stealth;
    public float strength;
    public float speed;

    public StatSet (float _maxHealth, float _maxMana, float _stealth, float _strength, float _speed) {
        maxHealth = _maxHealth;
        maxMana = _maxMana;
        stealth = _stealth;
        strength = _strength;
        speed = _speed;
    }

    public StatSet (string filename) {
        string[] lines = System.IO.File.ReadAllLines(filename);
        maxHealth = float.Parse(lines[0]);
        maxMana   = float.Parse(lines[1]);
        stealth   = float.Parse(lines[2]);
        strength  = float.Parse(lines[3]);
        speed     = float.Parse(lines[4]);
    }
}