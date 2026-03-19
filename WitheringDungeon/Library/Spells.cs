using System.Diagnostics.CodeAnalysis;

public class Spell
{
    public string Name { get; set; }
    public int Damage { get; set; }
    public string StatAffect { get; set; }
    public int Mana { get; set; }
    public string Type { get; set; }
    public string Sequence { get; set; }

    public Spell(string name, int damage, string stat, int mana, string type, string sequence)
    {
        Name = name;
        Damage = damage;
        Mana = mana;
        Type = type;
        Sequence = sequence;
        StatAffect = stat;
    }
}

public static class Spells
{
    public static Spell DragonsBreath { get; } = new Spell("Dragon's Breath", 5, "health", 3, "fire", "'The Sorcerors Hearts' begins to glow, sending a wave of energy up your arm and through your entire body. Heat builds in the base of your throat and your mind is filled a burning, ancient rage. You make to let out a mighty roar and thick flames erupt from your open maw like [some sort of liquid metaphor]. The torrid stream hits your opponent and engulfs them in bright flames");//change sequence to string list from story class
    public static Spell EnergyBlast { get; } = new Spell("Energy Blast", 3, "health", 1, "basic", "You raise your arm, summoning power from 'The Sorcerors Heart'. A blast of pure energy fires from your open hand and flies at your opponent, striking them");
    public static Spell WitheringShriek { get; } = new Spell("Withering Shriek", 10, "health", 0, "wither", "Silence fills the chamber for a second and as you look on you see every mouth accrss the foul creatures cursed face stretching open. Hundreds of gnarled teeh bared, the Shade lets loose hundreds of iercing screams, shaking the room and throwing you back against the wall");
    public static Spell EncapsulatingShadow { get; } = new Spell("Encapsulating Shadow", 5, "evasiveness", 0, "shadow", "The whispers of the foul creature grow louder and from every corner of the room, shadows snake towards you, wrapping round your body and robbing you of your vision. You struggle against the ensnaring darkness, your movements slowed");
}

