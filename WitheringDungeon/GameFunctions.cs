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
            string userInput = Console.ReadLine()!;
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
                string input=reader.ReadLine()!;
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