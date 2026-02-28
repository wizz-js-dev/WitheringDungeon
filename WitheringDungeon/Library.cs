using System.Diagnostics;
using System.Drawing;
using System.Text;

public static class Spells
{
    public static Spell DragonsBreath { get; } = new Spell("Dragon's Breath", 5, "health", 3, "fire", "'The Sorcerors Hearts' begins to glow, sending a wave of energy up your arm and through your entire body. Heat builds in the base of your throat and your mind is filled a burning, ancient rage. You make to let out a mighty roar and thick flames erupt from your open maw like [some sort of liquid metaphor]. The torrid stream hits your opponent and engulfs them in bright flames");//change sequence to string list from story class
    public static Spell EnergyBlast { get; } = new Spell("Energy Blast", 3, "health", 1, "basic", "You raise your arm, summoning power from 'The Sorcerors Heart'. A blast of pure energy fires from your open hand and flies at your opponent, striking them");
    public static Spell WitheringShriek { get; } = new Spell("Withering Shriek", 10, "health", 0, "wither", "Silence fills the chamber for a second and as you look on you see every mouth accrss the foul creatures cursed face stretching open. Hundreds of gnarled teeh bared, the Shade lets loose hundreds of iercing screams, shaking the room and throwing you back against the wall");
    public static Spell EncapsulatingShadow { get; } = new Spell("Encapsulating Shadow", 5, "speed", 0, "stat", "The whispers f the foul creature grow louder and from every corner of the room, shadows snake towards you, wrapping round your body and robbing you of your vision. You struggle against the ensnaring darkness, your movements slowed");
    // public static List<Spell> SpellBook{get;set;}

    // public static List<Spell> AllSpells()
    // {
    //     DragonsBreath= new Spell("Dragons Breath",5,3,"fire","you open your blaaaaaa");
    //     SpellBook.Add(DragonsBreath);
    //     return SpellBook;
    // }
}
public static class Weapons
{
    public static Weapon FeatherFlight { get; } = new Weapon("Featherflight Bow","A large, wooden bow with roots carved into it. and a leather quiver of arrows", 5, "ranged", "You reach into the quiver on your back, retrieving and then nocking an arrow on the mighty bow. You empty your mind, draw back the string, take aim and release, watching the arrow fly through the air. The Sharp tip hits its target");
    public static Weapon SerpentsFang { get; } = new Weapon("Serpents Fang","A large, bright red broad sword with an ornately molded hilt and ruby in the pommel", 9, "piercing", "Mighty sword in hand, you rush forward raising the blade high above your head. You bring the sharp edge down with great force against the flesh of your opponent");
    public static Weapon BrokenShield { get; } = new Weapon("Broken Shield","An old, nearly broken wooden shield", 5, "shield", "You hold up the broken shield and brace yourself for the next attack. +5 defence");
    public static Weapon TwistedLimb { get; } = new Weapon("Twisted Limb","The gnarled limb of the vicious WIthering Shade", 7, "physical", "From the sea of shadow encircling the creature, a long, twisted limb raises high above its body and shoots forward, striking you and knocking you back");
}
public static class Characters
{
    public static Character player { get; } = new Character("Wizz", 20, "poison");
    public static Character witheringShade { get; } = new Character("The Withering Shade", 25, "fire");
}
public static class Items
{
    public static UseableItem DraughtVitality = new UseableItem("Draught of Vitality", "A small glass vial containing a swirling dark red liquid", 5, "health");
    public static UseableItem ElixirMagic = new UseableItem("Elixir of Magic", "A small glass vial containing a glittering blue liquid", 5, "mana");
    public static Item AncientRoot = new Item("Ancient Root","A small, piece of the root of some ancient tree. Petrified Moss clings to its surface");
    public static Item TwistedBlackShardOne = new Item("Twisted Black Metal Shard(1)","A sharp, gnarled piece of cold black metal. It makes you uncomfortable to look at it");
    public static Item TwistedBlackShardTwo = new Item("Twisted Black Metal Shard(2)","A sharp, gnarled piece of cold black metal. It seems to be repelled by the other shard in your pack");
    public static Item FieryGemstone = new Item("Fiery Gemstone","A large roung ruby that looks like it has flames licking at its surface from within");
}

public static class GameFunctions
{
    public static int CheckOption(string[] options)
    {
        int availableOptions = options.Length-1;
        int option = 0;
        bool validInput = false;

        while (!validInput)
        {
            Console.WriteLine(string.Join(" - ", options));
            Console.WriteLine($"Choose an option from 0-{availableOptions}");
            string userInput = Console.ReadLine();
            try
            {
                option = int.Parse(userInput);
                if (option <= availableOptions)
                {
                    validInput = true;
                    return option;
                }
                else
                {

                    Console.WriteLine($"Please choose a number between 0 and {availableOptions}");
                }
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message + "Try Again!");
            }
        }
        return option;
    }
    public static int StatInputChecker(int pointsAvailable,string stat,TextReader reader)
    {
        //is called once for each stat, input needs to be in here
        if (pointsAvailable > 0)
        {
            bool numberValid = false;
            while (!numberValid)
            {
                Console.WriteLine($"How many points would you like to assign to {stat}");
                string input=reader.ReadLine();
                try
                {
                    int statValue = int.Parse(input);
                    if (statValue <= pointsAvailable)
                    {
                        numberValid = true;
                        return statValue;
                    }
                    else
                    {
                        Console.WriteLine($"{statValue} is out of range, please enter a number less than {pointsAvailable}");
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine($"{input} is not a valid number, please try again!");
                }
            }
        }
        else
        {
            Console.WriteLine($"You are out of Attribute points. {stat} will be 0");
            return 0;
        }
        return 0;
    }
    
    public static void Dialogue(List<string> lines)
    {
        foreach(string line in lines)
        {
            Console.WriteLine(line);
            Console.ReadLine();
        }
    }
    public static bool Menu()
    {
        bool inMenu=true;
        while (inMenu)
        {
            switch (GameFunctions.CheckOption(GameOptions.MenuOptions))
            {
                case 0://Inventory
                foreach(Item item in Characters.player.Inventory)
                    {
                        Console.WriteLine($"{item.Name}: {item.Description}{Environment.NewLine}");
                    }
                break;
                case 1://Weapons
                    if (Characters.player.Equipped.Count > 0)
                    {
                        foreach(Weapon weapon in Characters.player.Equipped)
                        {
                            Console.WriteLine($"{weapon.Name}: {weapon.Description}{Environment.NewLine}. Damage: {weapon.Damage} | Type: {weapon.Type}{Environment.NewLine}");
                        }
                    }
                break;
                case 2://SpellBook
                    if (Characters.player.SpellBook.Count > 0)
                    {
                        foreach(Spell spell in Characters.player.SpellBook)
                        {
                            Console.WriteLine($"{spell.Name}:{Environment.NewLine}Damage: {spell.Damage}|Mana Cost: {spell.Mana} | Type: {spell.Type}");
                        }
                    }
                break;
                
                case 3://Stats and Progress
                Console.WriteLine($"Attack: {Characters.player.Attack} | Defence: {Characters.player.Defence} | Speed {Characters.player.Speed} | Health: {Characters.player.Health}{Environment.NewLine}Scrolls Collected: {Characters.player.Scrolls} out of 5");
                break;
                case 4://History
                case 5://Leave Menu
                inMenu=false;
                return true;
                case 6://Quit Game
                return false;
            }
        }
        return true;
    }
}
public static class GameOptions
    {
        public static string[] MenuOptions = new string[]
        {
            "0. Inventory",
            "1. Weapons",
            "2. Locked",
            "3. Stats and Progress",
            "4. History",
            "5. Leave Menu",
            "6. Quit Game"
        };
        public static string[] TakeScrollOne = new string[]
        {
            "0. Take Scroll","1. Leave it"
        };
        public static string[] EnterDungeon = new string[]
        { 
        "0. Bravely Push The Door Open","1. Turn back in fear"
        };
        public static string[] RoomOneNav = new string[]
        {
            "0. Menu", 
            "1. Investigate the alcove to the left", 
            "2. Cross to the GREEN door", 
            "3. Go to the centre of the room" 
        };
        public static string[] ChestOptions = new string[] 
        {
            "0. Try the clasp", 
            "1. Leave it be" 
        };
        public static string[] ChestItemOptions = new string[] 
        { 
            "0. Leave Alcove", 
            "1. The left vial", 
            "2. The right vial", 
            "3. The wooden box" 
            };
        public static string[] TryDoor = new string[]
        {
            "0. Try pushing door", 
            "1. Return to room"
        };
        public static string[] UseRoot = new string[]
        {
            "0. Try Ancient Root"
        };
        public static string[] PlinthOptions = new string[]
        {
            "0. Touch the runes",
            "1. Look into the Liquid"
        };
        public static string[] LiquidIfRuned = new string[]
        {
            "0. Run fingers across runes"
        };
        public static string[] TakeRootAndShard = new string[]
        {
            "0. Reach in and grab the items"
        };
        public static string[] InvestigateRecess = new string[]
        {
            "0. Go over and investigate"
        };
        public static string[] InvestigateMushroom = new string[]
        {
            "0. Try to touch wisp",
            "1. Look under mushroom cap"
        };
        public static string[] TakeScrollTwo = new string[]
        {
            "0. Take the item"
        };
        public static string[] CreepToDoor = new string[]
        {
            "0. Get to the GREEN door"
        };
        //Room Two Options

        public static string[] RoomTwoNav = new string[]
        {
            "0. Menu",
            "1. Investigate Roots",
            "2. Head over to RED door"
        };
        public static string[] ClimbRoots = new string[]
        {
            "0. Attempt to climb roots",
            "1. Look Elsewhere"
        };
        public static string[] JumpingChoices = new string[]
        {
            "0. Jump Left",
            "1 Jump Right"
        };
        public static string[] Jump = new string[]
        {
            "0. Jump"
        };
        //climb down option
        public static string [] ClimbDown = new string[]
        {
            "0. Climb down root"
        };
        public static string[] GrabSatchel = new string[]
        {
            "0. Grab satchel and search inside",
            "1 Leave it be"
        };
        public static string[] TryRed = new string[]
        {
            "0. Try pushing the door",
            "1. Back to room"
        };
        public static string[] TryGemstone = new string[]
        {
            "0. Try Gemstone"
        };
        public static string[] RedHandle = new string[]
        {
            "0. Turn the handle"
        };
        public static string[] ThroughRed = new string[]
        {
            "0. Walk through doorway"
        };
        public static string[] RoomThreeNav = new string[]
        {
            "0. Menu",
            "1. Investigate Chasm",
            "2. Investigate Crystals"
        };
        public static string[] TryCross = new string[]
        {
            "0. Find a way across",
            "1. Leave"
        };
        public static string[] TryMagic = new string[]
        {
            "0. Attempt Spell: Energy Blast"//consider mana cost
        };
        public static string[] FirstCrystal = new string[]
        {
            "0. YELLOW crystal"
        };
        public static string[] CrystalPuzzle = new string[]
        {
            "0. Continue using Energy Blast on crystals",
            "1. Look for another way across"
        };
        public static string[] CrystalChoices = new string[] 
        { 
            "0. YELLOW", 
            "1. PURPLE", 
            "2. ORANGE", 
            "3. WHITE" 
        };
    }