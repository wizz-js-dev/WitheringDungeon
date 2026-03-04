public class Move
{

    public string Name { get; set; }

    public int Damage { get; private set; }

    public string Type { get; private set; }

    public string Sequence { get; private set; }
    public int Mana { get; private set; }
    public string Stat { get; private set; }

    public void Cast(Spell spell)
    {
        Name = spell.Name;
        Damage = spell.Damage;
        Type = spell.Type;
        Sequence = spell.Sequence;
        Mana = spell.Mana;
        Stat = spell.StatAffect;
    }
    public void Use(Weapon weapon)
    {
        Name = weapon.Name;
        Damage = weapon.Damage;
        Type = weapon.Type;
        Sequence = weapon.Sequence;
        Mana = 0;
        Stat = "health";
    }
}