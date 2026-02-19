using Microsoft.VisualBasic;

namespace WitheringDungeon;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Greetings adventurer! Prey tell, what is your name?");
        string playerName = Console.ReadLine();
        List<string> inventory = new List<string>();
        //will populate as i build story
        List<KeyValuePair<string, int>> stats = new List<KeyValuePair<string, int>>();
        Console.WriteLine("Lets see how strong you are!");
        stats.AddRange(StatsAssign());
        List<string> history = new List<string>
        {
            "You have travelled a great distance in search of 'The scrolls of Tash'kar', in order to bring peace to your homeland!",
            "You faced many trials on your journey, won many battles and escaped a great many dangers!",
            "All you have been through has led you here, to your final destination, the Withering Dungeon, wherin, you are told, 'The Scrolls of Tash'Kar' were hidden centuries ago to be retrieved when war threatened to ruin the land",
            "Days have passed since you entered the dungeon, venturing deeper and deeper in to the depths of the earth, steadfast in your search.",
            "You now stand before a great stone door standing slightly ajar, carved into which are many warnings in every language of the land, some so ancient you barely recognise them!",
            "Each warning reads the same, be it artfully carved or hurriedly scratched in to the stone.",
            "===Turn Back! DEATH Lies in wait within==",
            "====Turn Back! DEATH Lies in wait within===",
            "=====Turn Back! DEATH Lies in wait within===="
        };
        Console.WriteLine($"Greetings traveller {playerName}!");
        NextThroughDialogue(history);
        string[] startGameOptions = new string[] { "0. Menu", "1. Bravely push the door open", "2. Turn Back in fear" };
        Console.WriteLine("What will you do?");
        // Console.WriteLine(string.Join(" - ",startGameOptions));
        bool gamePlay = true;
        while (gamePlay)
        {
            int startChoice = CheckOption(startGameOptions);

            if (startChoice == 1)
            {
                Console.WriteLine($"You chose {startGameOptions[startChoice]}");
                List<string> backFromOneRecord = new List<string>();
                backFromOneRecord.AddRange(RoomOne(inventory,stats,history));
                if(backFromOneRecord[^1]=="EXIT")
                {
                    gamePlay=false;
                }
                history.Clear();
                history.AddRange(backFromOneRecord);
                //method to go into room1
                //returns a record of actions
                //check last value to decide which room next
                //same again except both will go to room 4
            }
            else if (startChoice == 2)
            {
                Console.WriteLine($"You look at the warnings on the door and are filled with dread! 'Peace is overrated' you think to yourself.'Who doesnt love a good war!' Perhaps instead of becoming {playerName} the Brave, or {playerName}, Saviour of the Lands, you could become {playerName.ToUpper()} the great war hero.{playerName.ToUpper()} the Vanquisher!");
                Console.ReadLine();
                Console.WriteLine($"Or perhaps you are just {playerName.ToLower()} the cowardly. Forgotten to time as war ravages the land.");
                Console.ReadLine();
                Console.WriteLine("You turn away from the door and make to leave the dungeon when you hear soft whispers like scratches on stone coming from the slightly open door behind you");
                Console.ReadLine();
                Console.WriteLine("You barely have a moment to turn before darkness surrounds you and fills you, icy cold and sharp");
                Console.ReadLine();
                Console.WriteLine("You die a cowardly death!");
                Console.ReadLine();
                gamePlay = false;
            }
            else if (startChoice == 0)
            {
                gamePlay = Menu(inventory, stats, history);
            }

        }






    }
    public static List<KeyValuePair<string, int>> StatsAssign()
    {
        int statPoints = 5;
        string[] attributes = { "Attack", "Defence", "Speed" };
        List<KeyValuePair<string, int>> assignedStats = new List<KeyValuePair<string, int>>();
        bool accepted = false;
        while (!accepted)
        {
            for (int i = 0; i < 3; i++)
            {
                if (statPoints != 0)
                {
                    bool numberValid = false;
                    while (!numberValid)
                    {
                        Console.WriteLine($"You have {statPoints} stat points. Please choose how many you'd like to assign to {attributes[i]}");
                        string userInput = Console.ReadLine();
                        try
                        {
                            int statValue = int.Parse(userInput);
                            if (statValue <= statPoints && statPoints > 0)
                            {
                                assignedStats.Add(new KeyValuePair<string, int>(attributes[i], statValue));
                                statPoints -= statValue;
                                numberValid = true;
                            }
                            else
                            {
                                Console.WriteLine($"{statValue} is out of range. Please try again!");
                            }
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine($"{userInput} is not a valid number. Please try again!");
                        }
                    }

                }
                else
                {
                    Console.WriteLine($"You are out of stat points. {attributes[i]} will be 0");
                    assignedStats.Add(new KeyValuePair<string, int>(attributes[i], 0));
                }
            }
            bool validAnswer = false;
            while (!validAnswer)
            {
                Console.WriteLine($"Your assigned stats are {string.Join(',', assignedStats)} Accept?(y/n)");
                string acceptInput = Console.ReadLine().ToLower();
                try
                {

                    char acceptStats = char.Parse(acceptInput);
                    if (acceptStats == 'y')
                    {
                        validAnswer = true;
                        accepted = true;
                    }
                    else
                    {
                        validAnswer = true;
                        assignedStats.Clear();
                        statPoints = 5;
                        Console.WriteLine($"Stat points reset to {statPoints}");
                    }
                }
                catch (FormatException ex)
                {
                    Console.WriteLine(ex.Message + "Try Again!");
                }

            }
        }
        return assignedStats;
    }
    public static int CheckOption(string[] options)
    {
        int availableOptions = options.Length;
        int option = 0;
        bool validInput = false;

        while (!validInput)
        {
            Console.WriteLine(string.Join(" - ", options));
            Console.WriteLine($"Choose an option from 1-{availableOptions - 1}");
            string userInput = Console.ReadLine();
            try
            {
                option = int.Parse(userInput);
                if (option < availableOptions)
                {
                    validInput = true;
                    return option;
                }
                else
                {

                    Console.WriteLine($"Please choose a number between 1 and {availableOptions}");
                }
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message + "Try Again!");
            }
        }
        return option;
    }

    public static void NextThroughDialogue(List<string> dialogueLines)
    {
        foreach (string line in dialogueLines)
        {
            Console.WriteLine(line);
            Console.ReadLine();
        }
    }

    public static bool Menu(List<string> inv, List<KeyValuePair<string, int>> sta, List<string> his)
    {//called as assignment to gameplay. all true except quit. Pass in menu items
        string[] menuOptions = new string[] { "0. Inventory", "1. Stats", "2. History", "3. Quit Game" };
        Console.WriteLine("===MENU===");
        int choice = CheckOption(menuOptions);
        switch (choice)
        {
            case 1:
                Console.WriteLine("Your pack contains:" + Environment.NewLine + string.Join(',', inv));
                return true;
                break;
                //add a way to use an item later
            case 2:
                Console.WriteLine("Your stats are:" + Environment.NewLine + string.Join(',', sta));
                return true;
                break;
            case 3:
                Console.WriteLine("Your journey so far");
                NextThroughDialogue(his);
                return true;
                break;
            case 4:
                string[] quitOptions = new string[] { "1. Yes Quit", "2. No, continue Game" };
                Console.WriteLine("Are you sure you want to quit?");
                if (CheckOption(quitOptions) == 1)
                {
                    return false;
                }
                else
                {
                    return true;
                }
                break;
            default:
                return true;
                break;
        }

    }
    public static List<string> RoomOne(List<string> inv, List<KeyValuePair<string, int>> sta, List<string> his)
    {
        bool alreadySeen = false;
        bool chestOpen = false;
        List<string> roomRecord = new List<string>();
        roomRecord.AddRange(his);
        List<string> roomDescription = new List<string>
        {
            "You walk in to a dark circular room, cast in dim green light which barely reaches the shadowy wall",
            "There are small pools of water strewn accross the uneven stone floor and the air smells rancid like mold and putrid meat",
            "Covering most of the walls and floor is a thick tange of dark moss, from which sprout glowing mushrooms",
            "Looking up, you see several magical wisps of energy, dancing through the air, glowing lime green. Above them, you cannot see the ceiling of the room",
            "Glinting in their light is a thick dust like haze which fills the room",
            "To your left, you can make out a small alcove in the wall. Every so often, something seems to catch the light of the entities above",
            "There are two large metal doors breaking the jagged round walls. One is blue, the other red. They both appear to have images etched on to their surface, however you can't make out what they are",
            "In the centre of the room is a circular stone plinth, atop which sits a shallow stone bowl holding some sort of liquid, occasionally reflecting the glow from above"
        };
        List<string> alcoveDescription = new List<string>
        {
            "You approach the small alcove in the wall and discover a small chest sitting in the shadow",
            "Its dark wood is rotting away, and is only held together by its rusted metal frame",
            "The chest is shut and there is a clasp with a keyhole on the front which can be lifted"
        };
        string[] alcoveOptions = new string[] { "0. Menu", "1. Try the clasp", "2. Leave it be" };
        string[] roomOptions = new string[] { "0. Menu", "1. Investigate the alcove to the left", "2. Cross to the BLUE door", "3. Cross to the RED door", "4. Go to the centre of the room" };
        NextThroughDialogue(roomDescription);
        bool moveOn = false;
        while (!moveOn)
        {
            Console.WriteLine("What do you do?");
            int choice = CheckOption(roomOptions);
            switch (choice)
            {
                case 1:
                    if (!chestOpen)
                    {
                        NextThroughDialogue(alcoveDescription);
                        bool choosing = true;
                        while (choosing)
                        {
                            int chestChoice = CheckOption(alcoveOptions);
                            if (chestChoice == 0)
                            {
                                bool gameState=Menu(inv,sta,his);
                                if(!gameState)
                                {
                                    roomRecord.Add("EXIT");
                                    moveOn=true;
                                    choosing=false;
                                    
                                }
                            }
                            else if (chestChoice == 1)
                            {
                                Console.WriteLine("Open the chest bit");
                                choosing=false;
                                moveOn=true;
                                //then leave so -- end loop
                            }
                            else if(chestChoice==2)
                            {
                                Console.WriteLine("Leave alcove, return to room");
                                choosing=false;
                                moveOn=true;
                            }
                        }


                    }
                    break;
            }

        }
        return roomRecord;
    }
}
