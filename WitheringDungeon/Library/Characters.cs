public class Character
{
    public string Name { get; set; }
    public int Attack { get; set; }
    public int Defence { get; set; }
    public int Speed { get; set; }
    public int AttributePoints;//for assigning stats
    public int Mana { get; set; }
    public int Health { get; set; }
    public string Weakness { get; set; }//attk boost to opponent 
    public int Evasiveness { get; set; }//speed boost in combat
    public List<Spell> SpellBook { get; private set; }
    public List<Item> Inventory { get; private set; }
    public List<Weapon> Equipped { get; private set; }
    public int Scrolls{get;set;}
    //need history list
    //also some sort of scrolls progress tracker that can be displayed from menu??

    public Character(string name, int health, string weak)
    {
        Name = name;
        Attack = 0;
        Defence = 0;
        Speed = 0;
        AttributePoints = 5;
        Mana = 0;//assign when get magic
        Health = health;
        Weakness = weak;
        Evasiveness = 0;
        Scrolls=0;
        SpellBook = new List<Spell>();
        Inventory = new List<Item>();
        Equipped = new List<Weapon>();
    }
    public void Restore(UseableItem item)
    {
        switch (item.Attribute)
        {
            case "health":
                Health += item.Boost;
                break;
            case "mana":
                Mana += item.Boost;
                break;
        }
        Inventory.Remove(item);
        Console.WriteLine($"Restored {item.Boost} {item.Attribute} points");
    }
    public void TakeDamage(int damage)
    {
        if (damage > 0)
        {
            Health -= damage;
        }
        else
        {
            Health -= 1;
        }

    }
    public void PickUp(Item item)
    {
        Inventory.Add(item);
        Console.WriteLine($"~~You added 1 {item.Name} to your pack");
    }
    public void Use(Item item)
    {
        Inventory.Remove(item);
    }
    public void Equip(Weapon weapon)
    {
        Equipped.Add(weapon);
        Console.WriteLine($"~~You equipped {weapon.Name}");
    }
    public void Learn(Spell spell)
    {
        SpellBook.Add(spell);
        Console.WriteLine($"~~You learned the spell {spell.Name}");
    }
    public int NewScroll()
    {
        Scrolls++;
        return Scrolls;
    }
    public void NameAssign (string name)
    {
        Name=name;
        Console.WriteLine($"Welcome, traveller {Name}");
        Console.ReadLine();
    }
    public void StatAssign(TextReader reader)
    {
        int restoreValue=AttributePoints;
        bool accepted = false;
        List<int> stats = new List<int> { Attack, Defence, Speed };
        while (!accepted)
        {
            Console.WriteLine($"You have {AttributePoints} attribute points to assign");
            Attack=GameFunctions.StatInputChecker(AttributePoints,"Attack",reader);
            AttributePoints-=Attack;
            Defence=GameFunctions.StatInputChecker(AttributePoints,"Defence",reader);
            AttributePoints-=Defence;
            Speed=GameFunctions.StatInputChecker(AttributePoints,"Speed",reader);
            AttributePoints-=Speed;
            string[] options = new string[]{"0. Accept","1. Start Again"};
            Console.WriteLine($"You have assigned Attack: {Attack}, Defence: {Defence}, Speed: {Speed}");
            if (GameFunctions.CheckOption(options) == 0)
            {
                Console.WriteLine("Stats Assigned. Check anytime from the menu");//which im now gonna need to code in, cheers!
                accepted=true;
            }
            else
            {
                AttributePoints=restoreValue;
            }
            
        }
        
    }
    public void Cast(Spell spell,Character defender)
    {
        int bonus=0;
        if (Speed + GameFunctions.D20Roll() > defender.Evasiveness)
        {
            int damage=Attack+spell.Damage+bonus-defender.Defence;
            Mana-=spell.Mana;
            Console.WriteLine(spell.Sequence);
            Console.ReadLine();
            switch (spell.StatAffect)
            {
                case "health":
                defender.Health-=damage;
                Console.WriteLine($"{defender.Name} loses {damage} {spell.StatAffect} points.");
                Console.ReadLine();
                break;
                case "evasiveness":
                defender.Evasiveness-=spell.Damage;
                Console.WriteLine($"{defender.Name} loses {spell.Damage} {spell.StatAffect} points.");
                Console.ReadLine();
                break;
            }
        }
    }
    public void AttackWith (Weapon weapon, Character defender)
    {
        if (Speed + GameFunctions.D20Roll() > defender.Evasiveness)
        {
            int damage = Attack+weapon.Damage-defender.Defence;
            defender.Health-=damage;
            Console.WriteLine(weapon.Sequence);
            Console.ReadLine();
            Console.WriteLine($"{defender.Name} loses {damage} health");
            Console.ReadLine();
        }
        else
        {
            Console.WriteLine($"{Name} trys attacking with {weapon.Name} but misses!");
        }
    }
}

public static class Characters
{
    public static Character player { get; } = new Character("", 20, "poison");
    public static Character witheringShade { get; } = new Character("The Withering Shade", 25, "fire");
}

