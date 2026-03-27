public class Weapon
{
    public string Name { get; set; }
    public string Description{get;set;}
    public int Damage { get; set; }
    public string Type { get; set; }
    public string Sequence { get; set; }

    public Weapon(string name,string descr, int damage, string type, string sequence)
    {
        Name = name;
        Description=descr;
        Damage = damage;
        Type = type;
        Sequence = sequence;
    }
}

public static class Weapons
{
    public static Weapon FeatherFlight { get; } = new Weapon("Featherflight Bow","A large, wooden bow with roots carved into it. and a leather quiver of arrows", 5, "ranged", "You reach into the quiver on your back, retrieving and then nocking an arrow on the mighty bow. You empty your mind, draw back the string, take aim and release, watching the arrow fly through the air. The Sharp tip hits its target");
    public static Weapon SerpentsFang { get; } = new Weapon("Serpents Fang","A large, bright red broad sword with an ornately molded hilt and ruby in the pommel", 9, "piercing", "Mighty sword in hand, you rush forward raising the blade high above your head. You bring the sharp edge down with great force against the flesh of your opponent");
    public static Weapon BrokenShield { get; } = new Weapon("Broken Shield","An old, nearly broken wooden shield", 5, "shield", "You hold up the broken shield and brace yourself for the next attack. +5 defence");
    public static Weapon TwistedLimb { get; } = new Weapon("Twisted Limb","The gnarled limb of the vicious WIthering Shade", 7, "physical", "From the sea of shadow encircling the creature, a long, twisted limb raises high above its body and shoots forward, striking you and knocking you back");
}

