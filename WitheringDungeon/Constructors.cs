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
    public void Equip(Weapon weapon)
    {
        Equipped.Add(weapon);
        Console.WriteLine($"~~You equiped 1 {weapon}");
    }
    public void Learn(Spell spell)
    {
        SpellBook.Add(spell);
        Console.WriteLine($"~~You learned the spell {spell}");
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
}
public class Item
{
    public string Name { get; set; }
    public string Description { get; set; }


    public Item(string name, string descr)
    {
        Name = name;
        Description = descr;
    }
}
public class UseableItem : Item
{
    public int Boost { get; set; }
    public string Attribute { get; set; }

    public UseableItem(string name, string descr, int boost, string attr) :base(name,descr)
    {
        Name = name;
        Description = descr;
        Boost = boost;
        Attribute = attr;
    }
}