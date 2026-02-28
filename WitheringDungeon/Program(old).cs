// using Microsoft.VisualBasic;

// namespace WitheringDungeon;

// class Program
// {
//     static void Main(string[] args)
//     {
//         Console.WriteLine("Greetings adventurer! Prey tell, what is your name?");
//         /*
//         public static Character player = new Character(Console.ReadLine(),hp,mana,weakness) *change constructor to initialise empty stats
//         this cant go here. make above changes in library and then just update here
//         */
//         string playerName = Console.ReadLine();
//         List<KeyValuePair<string, string>> inventory = new List<KeyValuePair<string, string>>();
//         List<KeyValuePair<string, string>> spells = new List<KeyValuePair<string, string>>();
//         //will populate as i build story
//         List<KeyValuePair<string, int>> stats = new List<KeyValuePair<string, int>>();
//         List<string> checker = new List<string>();
//         // if(checker.Contains("test"))
//         // {
//         //     Console.WriteLine("It works");
//         // }
//         Console.WriteLine("Lets see how strong you are!");
//         stats.AddRange(StatsAssign());
//         List<string> history = new List<string>
//         {
//             "You have travelled a great distance in search of 'The scrolls of Tash'kar', in order to bring peace to your homeland!",
//             "You faced many trials on your journey, won many battles and escaped a great many dangers!",
//             "All you have been through has led you here, to your final destination, the Withering Dungeon, wherin, you are told, 'The Scrolls of Tash'Kar' were hidden centuries ago to be retrieved when war once again threatened to ruin the land",
//             "Days have passed since you entered the dungeon, venturing deeper and deeper in to the depths of the earth, steadfast in your search.",
//             "You now stand before a great stone door standing slightly ajar, its face emblazened with carving of a warrior, sword in one hand, the other raised above is head surrounded by swirls of magic",
//             "Around the door, carved into the cold dark stone, are many warnings in every language of the land, some so ancient you barely recognise them!",
//             "Each warning reads the same, be it artfully carved or hurriedly scratched in to the stone.",
//             "===Turn Back! DEATH Lies in wait within==",
//             "====Turn Back! DEATH Lies in wait within===",
//             "=====Turn Back! DEATH Lies in wait within====",
//             "You look closer at the carving on the door and notice a small scroll, tucked between two outcroppings of metal"
//         };
//         List<string> scrollOne = new List<string>
//         {
//             "You pull the scroll free from its place in the door and unfurl it to reveal a long, handwritten message",
//             "The writing is elegantly scribed, flowing across the page in flourishes",
//             "It reads as follows:",
//             "--The Knight of Tash'kar--",
//             "--The armored figure depicted here is the mighty Knight of of the Tash'kar",
//             "--We the Tash'kar are a race of noble beings who live amongst the shadows of the trees. We are well known as powerful sorcerors",
//             "--If you are reading this, it is likely we have all long since parted from this world. Please read our story, and take heed",
//             "--Skilled in the dangerous art of Shadowmancy, we were feared not only by our enemies, but by our closest allies as well",
//             "--This fear festered in the hearts of the kingdoms of the land until one day a great war was declared against the Tash'Kar",
//             "--Friend and foe alike took up arms against us, determined to drive us from this land",
//             "--The war raged on for a hundred years as the now united races of the land threw their forces against our unrelenting shadow army",
//             "--It seemed as though the war would never end, until we the mighty Tash'kar, sent forth our greatest hero",
//             "--The result of the most powerful magic we could muster, The Knight of Tash'kar was an enchanted soldier who seemingly could not be slain",
//             "--Waves of enemy soldiers fell to their dark blade as they swept through the enemy forces. No one could stand against them",
//             "--Fearful for the safety of their kingdoms, the rulers of the land recalled their armies and declared forfeit",
//             "--While we were satisfied with this, set on returning to a time of peace, our fearsome Knight was not..",
//             "--Unbeknownst to us, the Twisted Kight left our dark forest and layed siege to the neighboring kingdom of Devarr",
//             "--There were no survivors",
//             "--When word of the slaughter reached the Tash'Kar Capital, we were horrified and set about preventing any further death at the dark knights hand...",
//             "The story fills you with a great feeling of pain and regret",
//             "You place the scroll in your pack and look to the great warrior on the stone door",
//             "SCROLLS: 1 of 5 collected"
//         };
//         Console.WriteLine($"Greetings traveller {playerName}!");
//         NextThroughDialogue(history);
//         string[] startGameOptions = new string[] { "0. Menu", "1. Bravely push the door open", "2. Turn Back in fear" };
//         Console.WriteLine("What will you do?");
//         // Console.WriteLine(string.Join(" - ",startGameOptions));
//         bool gamePlay = true;
//         while (gamePlay)
//         {
//             int startChoice = CheckOption(startGameOptions);

//             if (startChoice == 1)
//             {
//                 Console.WriteLine($"You chose {startGameOptions[startChoice]}");
//                 List<string> backFromOneRecord = new List<string>();
//                 backFromOneRecord.AddRange(RoomOne(inventory, stats, history, spells, checker));
//                 if (backFromOneRecord[^1] == "EXIT")
//                 {
//                     gamePlay = false;
//                 }
//                 history.Clear();
//                 history.AddRange(backFromOneRecord);
//                 //method to go into room1
//                 //returns a record of actions
//                 //check last value to decide which room next
//                 //same again except both will go to room 4
//             }
//             else if (startChoice == 2)
//             {
//                 Console.WriteLine($"You look at the warnings on the door and are filled with dread! 'Peace is overrated' you think to yourself.'Who doesnt love a good war!' Perhaps instead of becoming {playerName} the Brave, or {playerName}, Saviour of the Lands, you could become {playerName.ToUpper()} the great war hero.{playerName.ToUpper()} the Vanquisher!");
//                 Console.ReadLine();
//                 Console.WriteLine($"Or perhaps you are just {playerName.ToLower()} the cowardly. Forgotten to time as war ravages the land.");
//                 Console.ReadLine();
//                 Console.WriteLine("You turn away from the door and make to leave the dungeon when you hear soft whispers like scratches on stone coming from the slightly open door behind you");
//                 Console.ReadLine();
//                 Console.WriteLine("You barely have a moment to turn before darkness surrounds you and fills you, icy cold and sharp");
//                 Console.ReadLine();
//                 Console.WriteLine("You die a cowardly death!");
//                 Console.ReadLine();
//                 gamePlay = false;
//             }
//             else if (startChoice == 0)
//             {
//                 gamePlay = Menu(inventory, stats, history, spells);
//             }

//         }






//     }
//     public static List<KeyValuePair<string, int>> StatsAssign()//refactored
//     {
//         int statPoints = 5;
//         string[] attributes = { "Attack", "Defence", "Speed" };
//         List<KeyValuePair<string, int>> assignedStats = new List<KeyValuePair<string, int>>();
//         bool accepted = false;
//         while (!accepted)
//         {
//             for (int i = 0; i < 3; i++)
//             {
//                 if (statPoints != 0)
//                 {
//                     bool numberValid = false;
//                     while (!numberValid)
//                     {
//                         Console.WriteLine($"You have {statPoints} stat points. Please choose how many you'd like to assign to {attributes[i]}");
//                         string userInput = Console.ReadLine();
//                         try
//                         {
//                             int statValue = int.Parse(userInput);
//                             if (statValue <= statPoints)
//                             {
//                                 assignedStats.Add(new KeyValuePair<string, int>(attributes[i], statValue));
//                                 statPoints -= statValue;
//                                 numberValid = true;
//                             }
//                             else
//                             {
//                                 Console.WriteLine($"{statValue} is out of range. Please try again!");
//                             }
//                         }
//                         catch (FormatException)
//                         {
//                             Console.WriteLine($"{userInput} is not a valid number. Please try again!");
//                         }
//                     }

//                 }
//                 else
//                 {
//                     Console.WriteLine($"You are out of stat points. {attributes[i]} will be 0");
//                     assignedStats.Add(new KeyValuePair<string, int>(attributes[i], 0));
//                 }
//             }
//             bool validAnswer = false;
//             while (!validAnswer)
//             {
//                 Console.WriteLine($"Your assigned stats are {string.Join(',', assignedStats)} Accept?(y/n)");
//                 string acceptInput = Console.ReadLine().ToLower();
//                 try
//                 {

//                     char acceptStats = char.Parse(acceptInput);
//                     if (acceptStats == 'y')
//                     {
//                         validAnswer = true;
//                         accepted = true;
//                     }
//                     else
//                     {
//                         validAnswer = true;
//                         assignedStats.Clear();
//                         statPoints = 5;
//                         Console.WriteLine($"Stat points reset to {statPoints}");
//                     }
//                 }
//                 catch (FormatException ex)
//                 {
//                     Console.WriteLine(ex.Message + "Try Again!");
//                 }

//             }
//         }
//         return assignedStats;
//     }
//     public static int CheckOption(string[] options)//refactored
//     {
//         int availableOptions = options.Length;
//         int option = 0;
//         bool validInput = false;

//         while (!validInput)
//         {
//             Console.WriteLine(string.Join(" - ", options));
//             Console.WriteLine($"Choose an option from 1-{availableOptions - 1}");
//             string userInput = Console.ReadLine();
//             try
//             {
//                 option = int.Parse(userInput);
//                 if (option < availableOptions)
//                 {
//                     validInput = true;
//                     return option;
//                 }
//                 else
//                 {

//                     Console.WriteLine($"Please choose a number between 1 and {availableOptions}");
//                 }
//             }
//             catch (FormatException ex)
//             {
//                 Console.WriteLine(ex.Message + "Try Again!");
//             }
//         }
//         return option;
//     }

//     public static void NextThroughDialogue(List<string> dialogueLines)//refactored
//     {
//         foreach (string line in dialogueLines)
//         {
//             Console.WriteLine(line);
//             Console.ReadLine();
//         }
//     }

//     public static bool Menu(List<KeyValuePair<string, string>> inv, List<KeyValuePair<string, int>> sta, List<string> his, List<KeyValuePair<string, string>> mag)
//     {//called as assignment to gameplay. all true except quit. Pass in menu items
//         string[] menuOptions = new string[] { "0. Inventory", "1. Stats", "2. History", "3. Locked", "4. Quit Game" };
//         if (mag.Count != 0)
//         {
//             menuOptions[3] = "3. Spells";
//         }
//         Console.WriteLine("===MENU===");
//         int choice = CheckOption(menuOptions);
//         switch (choice)
//         {
//             case 0:
//                 Console.WriteLine("Your pack contains:" + Environment.NewLine + string.Join(',', inv));
//                 return true;
//                 break;
//             //add a way to use an item later
//             case 1:
//                 Console.WriteLine("Your stats are:" + Environment.NewLine + string.Join(',', sta));
//                 return true;
//                 break;
//             case 2:
//                 Console.WriteLine("Your journey so far");
//                 NextThroughDialogue(his);
//                 return true;
//                 break;
//             case 3:
//                 //magic menu
//                 break;
//             case 4:
//                 string[] quitOptions = new string[] { "1. Yes Quit", "2. No, continue Game" };
//                 Console.WriteLine("Are you sure you want to quit?");
//                 if (CheckOption(quitOptions) == 1)
//                 {
//                     return false;
//                 }
//                 else
//                 {
//                     return true;
//                 }

//         }
//         return true;
//     }
//     public static List<string> RoomOne(List<KeyValuePair<string, string>> inv, List<KeyValuePair<string, int>> sta, List<string> his, List<KeyValuePair<string, string>> mag, List<string> check)
//     {
//         List<string> roomDescription = new List<string>
//         {
//             "You walk in to a dark circular room, cast in dim blue light which barely reaches the shadowy wall",
//             "There are small pools of water strewn accross the uneven stone floor and the air smells rancid like mold and putrid meat",
//             "Covering most of the walls and floor is a thick tangle of dark moss, from which sprout glowing mushrooms",
//             "Looking up, you see several magical wisps of energy, dancing through the air, glowing icy blue. Above them, you cannot see the ceiling of the room",
//             "Glinting in their light is a thick dust like haze which fills the room",
//             "To your left, you can make out a small alcove in the wall. Every so often, something seems to catch the light of the entities above",
//             "There are two large metal doors breaking the jagged round walls. A Green door straight accross from you and a Red door to your right They both appear to have images etched on to their surface, however you can't make out what they are",
//             "In the centre of the room is a circular stone plinth, atop which sits a shallow stone bowl holding some sort of liquid, occasionally reflecting the glow from above"
//         };
//         List<string> progressNextRoom = new List<string>
//     {
//         "You step forward through the open door into a long dark corridor",
//         "As you make your way onward, a loud bang from behing takes with it any remaining light from the room behind",
//         "Steadfast, you march into the darkness.."
//     };

//         List<string> roomRecord = new List<string>();
//         roomRecord.AddRange(his);
//         string[] roomOptions = new string[] { "0. Menu", "1. Investigate the alcove to the left", "2. Cross to the GREEN door", "3. Cross to the RED door", "4. Go to the centre of the room" };
//         NextThroughDialogue(roomDescription);
//         bool moveOn = false;
//         while (!moveOn)
//         {
//             Console.WriteLine("What do you do?");
//             int choice = CheckOption(roomOptions);
//             switch (choice)
//             {
//                 case 1:
//                     bool chestOpen = false;
//                     List<string> alcoveDescription = new List<string>
// {
//     "You approach the small alcove in the wall and discover a small chest sitting in the shadow",
//     "Its dark wood is rotting away, and is only held together by its rusted metal frame",
//     "The chest is shut and there is a clasp with a keyhole on the front which can be lifted"
// };

// List<string> chestDescription = new List<string>
//     {
//         "You reach out, hook a finger under the clasp of the small chest and attempt to flip it up",
//         "It remains firmly in place at first, however with a bit more effort, you manage to move the old rusted metal",
//         "As you lift the battered lid up to see what lies within, the movement proves too much for the ancient wood and the entire box disintegrates into dust",
//         "Left behind on the wet stone shelf, covered in wet dust, you find 2 labeled glass vials containing mysterious liquids as well as a small, wooden box, apparently untouched by the ravages of time"
//     };

//                     List<string> pickUpPotVil = new List<string>
//                     {
//                         "You pick up the left most vial and peer at the label on its side",
//                         "++Draught of Vitality++",
//                         "This may be useful later on so you place it in your pack",
//                         "INVENTORY: Added 'Draught of Vitality'"
//                     };
//                     List<string> pickUpEliMag = new List<string>
//                     {
//                         "You pick up the right most vial and read the writing scrawled on its label",
//                         "--Elixir of Magic",
//                         "You may find a use for this yet, in the pack it goes",
//                         "INVENTORY: Added 'Elixir of Magic'"
//                     };
// List<string> pickUpRing = new List<string>
// {
//     "You pick up the small wooden box and flip the lid open",
//     "Inside you find a pristine, golden ring, inscribed with ancient script. Set into the ring is a brilliant white gem stone flecked throughout with shards of every colour",
//     "You look closer at the engaved writing and find to your surprise, that you can read it",
//     "##The Sorcerers Heart##",
//     "This is surely worth a lot and should keep your pockets full of gold and your home full of food for years to come were you to sell it",
//     "You place the small wooden box back on the shelf and gently slide the ring on to your finger, finding it fits perfectly",
//     "EQUIPPED: 'The Sorcerors Heart'",
//     "A rush of energy sweeps up your arm and the stone on the ring begins to glow",
//     "***YOU CAN NOW USE MAGIC***"
// };
//                     //with above the item you pick up decides which dialogue you get. if all then its the whole thing. Add items to inventory after
//                     //and print message each time
//                     //magic mechanic. option in menu. empty until this point. maybe says locked. then pass back the locked list and check if it contains a value. if so change it to spells
//                     //cant cast spells from menu, can only use them in battle
//                     List<KeyValuePair<string, string>> chestItems = new List<KeyValuePair<string, string>>()
//                     {
//                         new KeyValuePair<string,string>("Potion of Vitality","+5 Health"),
//                         new KeyValuePair<string,string>("Elixir of Magic","+5 Mana"),
//                         new KeyValuePair<string,string>("The Sorcerers Heart","Allows you to use magic")
//                     };
//                     //REMOVE MENU CHOICE WHEN NOT IN MAIN ROOM
//                     string[] itemOptions = new string[] { "0. Menu", "1. None", "2. The left vial", "3. The right vial", "4. The wooden box" };
//                     string[] alcoveOptions = new string[] { "0. Menu", "1. Try the clasp", "2. Leave it be" };
//                     if (!chestOpen)
//                     {
//                         NextThroughDialogue(alcoveDescription);
//                         bool choosing = true;
//                         while (choosing)
//                         {
//                             int chestChoice = CheckOption(alcoveOptions);
//                             if (chestChoice == 0)
//                             {
//                                 bool gameState = Menu(inv, sta, his, mag);
//                                 if (!gameState)
//                                 {
//                                     roomRecord.Add("EXIT");
//                                     moveOn = true;
//                                     choosing = false;

//                                 }
//                             }
//                             else if (chestChoice == 1)
//                             {
//                                 NextThroughDialogue(chestDescription);
//                                 //need to account for if box open but still items behind
//                                 bool choosingItem = true;
//                                 // chestOpen=true; //refactor to still access below if chest open
//                                 while (choosingItem)
//                                 {
//                                     if (!(check.Contains("potvil") && check.Contains("elimag") && check.Contains("ring")))
//                                     {
//                                         Console.WriteLine("Which of the items do you take?");
//                                         int itemChoice = CheckOption(itemOptions);
//                                         if (itemChoice != 0 && itemChoice != 1)
//                                         {
//                                             int item = itemChoice - 2;
//                                             if (!inv.Contains(chestItems[item]))
//                                             {
//                                                 itemOptions[itemChoice] = "-";
//                                                 inv.Add(chestItems[item]);
//                                                 switch (item)
//                                                 {
//                                                     case 0:
//                                                         check.Add("potvil");
//                                                         NextThroughDialogue(pickUpPotVil);
//                                                         break;
//                                                     case 1:
//                                                         check.Add("elimag");
//                                                         NextThroughDialogue(pickUpEliMag);
//                                                         break;
//                                                     case 2:
//                                                         check.Add("ring");
//                                                         NextThroughDialogue(pickUpRing);
//                                                         mag.Add(new KeyValuePair<string, string>("Magic Blast", "2 Damage"));
//                                                         //whispers happen. floating whisps get dim for a second. change this to after leave alcove
//                                                         break;
//                                                 }
//                                             }
//                                         }
//                                         else if (itemChoice == 0)
//                                         {
//                                             bool gameState = Menu(inv, sta, his, mag);
//                                             if (!gameState)
//                                             {
//                                                 roomRecord.Add("EXIT");
//                                                 moveOn = true;
//                                                 choosing = false;
//                                                 choosingItem = false;
//                                             }

//                                         }
//                                         else
//                                         {
//                                             choosingItem = false;
//                                         }

//                                     }
//                                     else
//                                     {
//                                         choosingItem = false;
//                                         chestOpen = true;
//                                     }
//                                 }
//                             }
//                             else if (chestChoice == 2)
//                             {
//                                 Console.WriteLine("Leave alcove, return to room");
//                                 choosing = false;
//                             }
//                         }
//                     }
//                     break;
//                 case 2:
//                     //Blue Door
//                     List<string> greenDoor = new List<string>
//                     {
//                         "You cross the dark room, damp room weaving between the !!!mushrooms!!! until you're standing before the Green Metal Door",
//                         "Around the door the stone has been carved into a frame of gnarled root, tangled up in each other",
//                         "The face of the door is etched with an image of a great tree. From its trunk, leafless branches spread up and out and symetrical twisted roots wind down the door",
//                         "There is no handle"
//                     };
//                     List<string> tryOpen = new List<string>
//                     {
//                         "You lift a hand and try to push the door open but it doesn't move",
//                         "You place both hands on it and push even harder and still nothing",
//                         "As you take your hands away you notice something you hadnt before",
//                         "In the centre of the door, below the carved tree trunk, is a slot where there should be a root"
//                     };
//                     List<string> openGreen = new List<string>
// {
//     "You retrieve the 'Ancient Root' from your pack and place it gently in the slot in the door",
//     "Nothing happens",
//     "Confused, you look back towards the stone plinth as if to ask what you should do",
//     "Then, you feel the ground beneath your feet shaking and hear a sound like the creak of a tree bending in a storm",
//     "You turn back to see the 'Ancient Root' glowing bright green. Its surface morphs as you look on into the same metal as the rest of the door",
//     "The rumbling grows more intense as the root seems to melt into the door",
//     "You shield your eyes from the ever brightening glow",
//     "Moments pass and the ground settles once again. You hear a loud thunk",
//     "You drop your hand to see no evidence that there was ever a peice missing from the now open door"
// };


//                     break;
//                 case 3:
                //     //Red Door
                //     List<string> redDoor = new List<string>
                // {
                //     "You make your way over to the Red door, your boots splashing through stagnant water as you go",
                //     "The door is impressively large and the rock surrounding it is carved in to sharp, crystal like points",
                //     "Accross the door, an image of a serpent has been molded into the metal spiraling outward, each scale carefully etched so it almost looks real",
                //     "In the centre of the door, where the serpents eye should be, sits only an empty space"
                // };
                //     List<string> tryRed = new List<string>
                // {
                //     "The door is so large, you doubt you'd be able to push it open",
                //     "Nonetheless, you press your shoulder against it, your face pressed close to the head of the serpent, and push with all your strength",
                //     "Nothing, not even a creak"
                // };
                //     List<string> openRed = new List<string>
                // {
                //     "From your bag, you take out the 'Fiery Gemstone' and place it in to the serpents eye",
                //     "As it clicks in to place, you begin to feel heat radiating off of the door"  ,
                //     "The heat grows more intense and as you gaze upon it, the serpents eye blinks",
                //     "The great red serpent begins to move back and forth across the door, the metal rippling like liquid",
                //     "It winds its way up towards the top of the door, its long tail stretching all the way down behind it",
                //     "A sound like metal under a blacksmiths hammer rings out into the room as the very tip of the tail lifts itself off of the door, sticking out and bending to the side",
                //     "A handle?",
                //     "You reach out and clasp your hand round the thick metal tail. It is warm to the touch",
                //     "You turn the handle and push the door, finding it gives way without much effort revealing darkness beyond"
                // };
//                     break;
//                 case 4:
//                     List<string> centrePlinth = new List<string>
//                     {
//                         "You move to the centre of the room and stand before the ornate stone plinth",
//                         "Atop the pillar, the shallow bowl appears to contain a swirling glittery liquid",
//                         "Around the rim, ancient lettering is etched into the stone",
//                         "You can't read what it says",
//                         "You stop closer to stand over the liquid and to your shock, you'dont see your reflection",
//                         ""
//                     };
//                     //examine the runes
//                     List<string> runes = new List<string>
//                 {
//                     "You run your hands round the edge of the bowl",
//                     "As you feel the carved runes under your fingers, each one in turn begins to glow a cold blue for moment"
//                 };
//                     List<string> mysteriousLiquid = new List<string>
//                 {
//                     "You lean closer, pearing into the mysterious billowing liquid",
//                     "While you still can't see your own reflection, you can suprisingly see the ceiling of the room above you",
//                     "Dancing across its surface, the magical blue wisps are synchronised now, all in a circle like a halo",
//                     "FIGURE OUT THE PUZZLE"
//                 };
//                     //peer closer at the liquid
//                     //Centre plinth + puzzle
//                     break;
//             }

//         }
//         //at the end, add every item in check to room record
//         //gets checked when out of method and then player updated accordingly
//         //could make a method to use check to update things later(pass in check, return list for each inv,spells,history)
//         //if above, could i have the entire story in one place to be accessed
//         return roomRecord;
//     }
//     public static List<string> RoomTwo(List<KeyValuePair<string, string>> inv, List<KeyValuePair<string, int>> sta, List<string> his, List<KeyValuePair<string, string>> mag, List<string> check)
//     {
//         List<string> roomRecord = new List<string>();
//         roomRecord.AddRange(his);
//         // List<string> name = new List<string>
//         // {

//         // };
//         List<string> enterGreen = new List<string>
//         {
//             "You make your way down the dark corridor, hearing only the tap of your boots on the stone floor",
//             "The sound changes to a soft crunch as you start to make out a soft green glow up ahead",
//             "You get closer and see a doorway ahead leading into a gently lit chamber",
//             "You walk through the door to find yourself in a large chamber, bigger than the last",
//             "The floor is covered in a thick, almost bouncy layer of moss and ancient rotten wood",
//             "From the walls all around, thick twisted roots reach out and cross the room",
//             "You look up to see the roots have broken through into the chamber all the way up to the distant ceiling",
//             "Dancing and weaving in between the roots, are playful green wisps of light like those in the last room",
//             "Accross from you, through the wooden web, you see a black door set into the wall"
//         };
//         List<string> tryDoor = new List<string>
//         {
//             "You approach the black door to find it bears no carving or inscriptions",
//             "The only feature breaking the otherwise flat facade is a key hole in the centre",
//             "You try to push the door, but to no avail",
//             "You need a 'Key'"
//         };
//         List<string> openBlackDoor = new List<string>
//         {
//             "Taking the 'Plain Black Key' from your bag, you try it in the key hole",
//             "As you turn it you hear a click and feel the key in your hand disintegrate into dust",
//             "The Black door follows suit and falls away like sand revealing a dark corridor beyond",
//             "You take one last glance back into the room to see that the dancing green wisps have disappeared leaving the room in shadows",
//             "You step through the doorway and are immediately plunged into darkness",
//             "Turning and feeling around with your hands you find that the empty space behind you has vanished leaving only a solid wall",
//             "You turn back to the empty darkness of the corridor and venture tentatively forth.."
//         };

//         List<string> beginClimb = new List<string>
//         {
//             "You step up the the closest root and press your weight against it to find it gives only slightly",
//             "Carefully you climb on to the ancient wood and look up through the tangle of roots",
//             "From where you stand you can just about make out a ledge far above you",
//             "You may be able to use the roots to climb up there",
//             "You look around to see there are to roots within jumping range of the one on which you stand",
//             "One to the LEFT and another to the RIGHT"
//         };

//         //1st Stage jumping puzzle
//         string[] jumpChoices = new string[] { "1. Left", "2. Right" };
//         List<string> jumpSuccess = new List<string>
//         {
//             "You launch yourself towards the root and manage to firmly grab hold of it",
//             "You scramble yourself up on to it and look around for where to go next"
//         };
//         List<string> jumpSuccessButNextFail = new List<string>
//         {
//             "You jump towards the root and at the last minute, manage to catch it in your hands",
//             "You lift your body and wrap your legs around the wood before hoisting yourself round and stand up",
//             "You look around to see only one choice for your next jump"
//         };
//         List<string> jumpFail = new List<string>
//         {
//             "You leap forward to the root and wrap your hands around it",
//             "As you try to lift yourself up on to it, you find the top is covered in a slimy layer of lychen",
//             "You try to grip on however your hands slip and you fall in to the open air below you",
//             "You tumble down and your fall is broken by the thick moss on the chamber floor",
//             "You make your way over to the first root and climb back on, determined to try again"
//             //Maybe take small amount of damage and if hp gets to 0 you fail the whole dungeon
//         };
        // List<string> jumpFailStage2 = new List<string>
        // {
        //     "You leap forward to the root and wrap your hands around it",
        //     "As you try to lift yourself up on to it, you find the top is covered in a slimy layer of lychen",
        //     "You try to grip on however your hands slip and you fall in to the open air below you",
        //     "You tumble downwards but manage to catch hold of the small ledge to stop your fall",
        //     "You make your way along the ledge to the end where the two roots are, determined to try again"
        //     //Maybe take small amount of damage and if hp gets to 0 you fail the whole dungeon
        // };
        // List<string> NextIsLedge = new List<string>
        // {
        //     "From where you stand you see that the ledge you saw earlier is within reach",
        //     "What do you do?",
        //     "1. JUMP"
        // };
        // List<string> jumpToLedge = new List<string>
        // {
        //     "You jump forward to the Ledge and your boots land on solid stone",
        //     "The ledge is narrow with only enough space for you and a large bundle of fabric to your left",
        //     "You lean down and pick up the strange item to find there is something wrapped within the old tattered cloth",
        //     "You pull the wrapping away to reveal a suspiciously well preserved wooden bow and a leather quiver of arrows",
        //     "Carved into the body of the bow you read the weapons name",
        //     "~~Featherflight~~",
        //     "You swing the quiver over your shoulder and he bow across your back and turn look out to the room of roots",
        //     "EQUIPPED: 'Featherflight Bow",
        //     "From your vantage point you see that the root platforms extend even higher up the room",
        //     "Near the ceiling you spy another stone outcropping which you can reach by climbing",
        //     "You shuffle along the small ledge to the end where there are two roots you could possibly jump to to make your way upwards"
        // };
        // List<string> toSecondLedge = new List<string>
        // {
        //     "You jump to the left root and as you are about to land on it, it vanishes revealing the large ledge",
        //     "You land hard on the stone and roll forward, soming to a stop against the chamber wall",
        //     "You stand up and dust yourself off, looking around",
        //     "You spot a small wooden chest tucked between the broken stones where the wall meets the platform and make your way towards it",
        //     "As you get closer, you hear chilling whispers coming from somewhere below you",
        //     "You peak over the edge of the outcropping to find the chamber below you still empty of anything alive",
        //     "Warily you head to the chest trying to ignore the haunting voices",
        //     "You pull the chest free from where sits and lift the lid to reveal a 'Plain Black Key' sitting inside, next to a 'Twisted Black Metal Shard",
        //     "You reach in to retrieve the contents and as your hands touch the cold metal of the Twisted sShard, the disembodied whispers stop leaving an empty cold silence to fill the room",
        //     "You put the key and shard in your pack",
        //     "INVENTORY: Added 'Plain Black Key'",
        //     "INVENTORY: Added 'Twisted Black Metal Shard'",
        //     "You look around for anything else but find nothing, so set about climbing back down to the chamber floor"
        // };
//         bool climbingStage1 = true;
//         while (climbingStage1)
//         {
//             int direction = CheckOption(jumpChoices);
//             if (direction == 1)
//             {
//                 NextThroughDialogue(jumpSuccessButNextFail);
//                 NextThroughDialogue(jumpFail);
//             }
//             else
//             {
//                 NextThroughDialogue(jumpSuccess);
//                 direction = CheckOption(jumpChoices);
//                 if (direction == 0)
//                 {
//                     NextThroughDialogue(jumpSuccessButNextFail);
//                     NextThroughDialogue(jumpFail);
//                 }
//                 else
//                 {
//                     int irellavantChoice = CheckOption(jumpChoices);
//                     NextThroughDialogue(jumpSuccess);
//                     Console.ReadLine();
//                     NextThroughDialogue(NextIsLedge);
//                     Console.ReadLine();
//                     NextThroughDialogue(jumpToLedge);
//                     inv.Add(new KeyValuePair<string, string>("Featherflight Bow", "3 ranged damage"));
//                     check.Add("bow");
//                     climbingStage1 = false;
//                 }
//             }
//         }
        // bool climbingStage2 = true;
        // bool result = true;
        // while (climbingStage2)
        // {
        //     int level = 0;
        //     int nextJump = CheckOption(jumpChoices);
        //     switch (level)
        //     {
        //         case 0:
        //             result = nextJump == 0 ? false : true;
        //             break;
        //         case 1:
        //             result = nextJump == 0 ? true : false;
        //             break;
        //         case 2:
        //             result = nextJump == 0 ? false : true;
        //             break;
        //         case 3:
        //             result = nextJump == 0 ? false : true;
        //             break;
        //         case 4:
        //             result = nextJump == 0 ? true : false;
        //             break;
        //         case 5:
        //             result = nextJump == 0 ? true : false;
        //             break;
        //     }
        //     if (level < 5)
        //     {
        //         if (result)
        //         {
        //             level++;
        //             NextThroughDialogue(jumpSuccess);
        //         }
        //         else
        //         {
        //             NextThroughDialogue(jumpFailStage2);
        //             level = 0;
        //         }
        //     }
        //     else
        //     {
        //         if (result)
        //         {
        //             NextThroughDialogue(toSecondLedge);
        //             inv.Add(new KeyValuePair<string, string>("Twisted Black Key", "Opens small Black Door"));
        //             climbingStage2 = false;
        //         }
        //         else
        //         {
        //             NextThroughDialogue(jumpFailStage2);
        //             level = 0;
        //         }
        //     }
        // }
//         return roomRecord;
//     }

//     public static List<string> RoomThree(List<KeyValuePair<string, string>> inv, List<KeyValuePair<string, int>> sta, List<string> his, List<KeyValuePair<string, string>> mag, List<string> check)
//     {
//         List<string> roomRecord = new List<string>();
//         roomRecord.AddRange(his);
//         // List<string> name = new List<string>
//         // {

//         // };
//         List<string> enterRedRoom = new List<string>
//         {
//             "Through the darkness you march, hearing the sound of your boots on the stone below echoing off the dark walls",
//             "In the distance you notice a gentle red glow breaking the darkness",
//             "As you draw nearer and the light grows brighter, you hear the sound under foot change from a dull thud to a high pitch ring, like the sound of a glass bell",
//             "You reach the glowing doorway and step through into the light",
//             "You stand in a bright chamber that is narrow and stretches on quite far ahead of you",
//             "In the stone walls, thousands of bright red glowing crystals stick out sharply at all angles",
//             "The floor beneath your feet is no longer stone, but smooth flat and translucent red as if you are standing atop the face of a giant ruby",
//             "You venture forward and find in the ground before you a massive hole stretching away from you to another ruby platform",
//             "In the distant wall on the other platform, you can make out a black door",
//             "Looking up you see four FLOATING CRYSTALS gently dipping and rising in the air just above the edge of the hole",
//             "From left to right the crystals are YELLOW, PURPLE, ORANGE and WHITE",
//             "Darting back and forth around the crystals with sharp, quick movements are bright red wisps of light"
//         };
//         List<string> investigateHole = new List<string>
//         {
//             "You approach the edge of the chasm and look down into the darkness below",
//             "There is no bottom in sight",
//             "Looking accross to the cliff face on the other side, you see only smooth crystal rising out of the shadows",
//             "You cannot see the cliff face on your side",
//             "The distance accross is far too great to jump",
//             "You walk over to the nearest wall hoping to find a path across",
//             "The jutting out crystals spread all the way across the gap",
//             "You make to test out gripping on to one and as your hand gets near, the crystal shrinks away back into the stone wall",
//             "You cannot climb across"
//         };
//         List<string> investigateCrystals = new List<string>
//         {
//             "You move to just underneath the FLOATING CRYSTALS and inspect them more closely"  ,
//             "They are not too high in the air and you think you may be able to reach them if you jump",
//             "You ready yourself and then spring upwards, stretching your hands out to try to grab hold of one of them",
//             "As you rise up, the crystals react by floating higher in the air, evading your clutches",
//             "You drop back down empty handed and notice on your outstretched hand, 'The Sorcerors Heart' has begun glowing bright white",
//             "Perhaps magic can help you here.."
//         };
//         //Crystal Puzzle

//         //choice to cast a spell, choose basic cast or w/e its called then present option to attack yellow crystal
//         List<string> attackFirstCrystal = new List<string>
//         {
//             "You set your sights on the YELLOW crystal and allow energy to flow through you from 'The Sorcerers Heart'",
//             "You raise your hand and release a burst of magic at the crystal",
//             "It hits the floating target making it glow bright yellow",
//             "A rumble sounds from the great chasm in front of you and you look towards it to see two RUBY PLATFORMS rising from the shadows",
//             "They come to a halt, level with the floor on which you stand, one directly at its edge and the other half way between the first and the other side",
//             "You fire again at the YELLOW crystal and look on as the two platforms slowly drop back in to the shadows below"
//         };
//         List<string> puzzleComplete = new List<string>
//         {
//             "As the last platform lifts into place, giving you a clear path across the chasm, a shimmer runs across the walls of the chamber through every crystal",
//             "The red wisps swirl round you and then dart out over the chasm, bobbing up and down over the platforms",
//             "You make your way to the edge and jump over to the first platform",
//             "Its slightly dips under your weight but then raises itself back up into position",
//             "You hop to the next platform and the same happens",
//             "As you ready to jump to the next foating crystal you notice the red wisps spiraling over head",
//             "From between the platform you stand on and the next, rises a clear flat crystal as tall as you are",
//             "It comes to a stop right in front of you and you see suspended within it an ornate red GREAT SWORD as well as a SMALL SCROLL and a small PLAIN BLACK KEY"
//         };

//         List<string> prizeCrystal = new List<string>
//         {
//             "You cast magic once more, asiming right at the large crystal and as the energy hits its surface, it shatters into pieces"  ,
//             "The crystal shards fall away into the chasm, leaving behind the GREAT SWORD and the SMALL SCROLL and PLAIN BLACK KEY floating before you"
//         };
//         List<string> takeSword = new List<string>
//         {
//             "You reach out and grasp the hilt of the GREAT SWORD",
//             "The metal under your hand is warm and smooth and there is a sparkling ruby set into the pommel",
//             "The guard is ornately molded to resemble twisting snakes with ruby eyes and sharp extended fangs",
//             "You pull the sword from its scabbard to reveal a bright red metal blade with perilously sharp edges",
//             "Inscribed down the flat of the blade is the weapons name",
//             "~~~Serpents Fang~~~",
//             "You afix the scabbard and sword to your belt",
//             "EQUIPPED: Serpents Fang"
//         };
//         List<string> takeScroll = new List<string>
//         {
//             "You reach forward and take the SMALL SCROLL from where it floats",
//             "You open it gently, to read its contents",
//             "-'Spell: Dragons Breath'-",
//             "-'5 Fire damage'-",
//             "-'Cost: 2 Mana'-",
//             "As your eyes reach the last word, the scroll sets alight in your hands, the flames flowing like a serpent round your arm and then back up to your hand ",
//             "The firey snake flows into 'The Sorcerors Heart' and is gone, leaving your arm burning from the inside",
//             "NEW SPELL: Dragons Breath"
//         };
//         List<string> takeKey = new List<string>
//         {
//             "You reach out and take the PLAIN BLACK KEY",
//             "As your hands wrap round the cold metal, all the light in the room flickers and dims",
//             "From below you, deep in the chasm you hear the sound of scraping against stone",
//             "You can also hear harsh, angry whispers like an angry, but quiet, mob growing ever closer",
//             "A chill runs down your entire frame as the scraping sound gets louder"
//         };
//         List<string> escapeRed = new List<string>
//         {
//             "Key still in hand, you hurriedly jump to the third platform, then the next and then finally to the other side of the chasm",
//             "As your feet hit the crystal ground, the ruby platforms behind you crack and splinter before falling away",
//             "The whispers are coming from all around now and the light coming from the walls is almost gone",
//             "You race over to the BLACK DOOR and quickly put the 'Plain Black Key' into the key hole in its centre and turn it",
//             "The key clicks in the lock, and then pushes itself back out into your hand",
//             "You look down to see the 'Plain Black Key' morphing its shape, folding over and in on itself like thick tar",
//             "The movements cease, leaving behind a gnarled, mess of metal behind which you quickly add to your pack",
//             "INVENTORY: Added 'Twisted Black Metal Shard",
//             "In front of you the door groans as it swings away and you feel yourself being push forward into the dark corridor beyond",
//             "You turn to see the red wisps, almost invisible now, urging you forward and soon you are through the doorway",
//             "Darkness engulfs you as all light fades and the doorway behind you dissapears leaving behind a solid stone wall",
//             "It is silent now but the memory of the scratching and whispering still echoes in your mind as you creep forward into the shadows.."
//         };
//         string[] chasm = new string[] { "_____", "_____", "_____", "_____" };
//         string platform = "|||||";
//         string emptySpace = "_____";
//         int platformCount = 0;
//         bool crystalPuzzle = true;
//         while (crystalPuzzle)
//         {
//             Console.WriteLine("Which crystal do you cast spell on?");
//             string[] crystalChoices = new string[] { "0. YELLOW", "1. PURPLE", "2. ORANGE", "3. WHITE" };
//             int crystalChoice = CheckOption(crystalChoices);
//             switch (crystalChoice)
//             {
//                 case 0:
//                     chasm[0] = chasm[0] == emptySpace ? platform : emptySpace;
//                     chasm[3] = chasm[3] == emptySpace ? platform : emptySpace;
//                     break;
//                 case 1:
//                     chasm[0] = chasm[0] == emptySpace ? platform : emptySpace;
//                     chasm[2] = chasm[2] == emptySpace ? platform : emptySpace;
//                     break;
//                 case 2:
//                     chasm[3] = chasm[3] == emptySpace ? platform : emptySpace;
//                     break;
//                 case 3:
//                     chasm[1] = chasm[1] == emptySpace ? platform : emptySpace;
//                     break;
//             }
//             foreach (string space in chasm)
//             {
//                 if (space == platform)
//                 {
//                     platformCount++;
//                 }
//             }
//             if (platformCount == 4)
//             {
//                 crystalPuzzle = false;

//             }
//         }

//         return roomRecord;
//     }
//     public static void WitheringShadeChamber(List<KeyValuePair<string, string>> inv, List<KeyValuePair<string, int>> sta, List<string> his, List<KeyValuePair<string, string>> mag, List<string> check)
//     {
//         List<string> enterFinalChamber = new List<string>
//         {
//             "You wander though the dark for what feels like days, accompanied only by the sound of your steps and the faint glow of 'The Sorcerers Heart' on your finger",
//             "You wonder if there will be anything at the end of this tunnel or if the warnings outside the first chamber were referring to your current predicament",
//             "Lost in an endless dark tunnel, doomed to die of hunger or go mad and forget who you are",
//             "Just as you are about to lose all hope of ever getting out alive, a mysterious white flame bursts to light on the tunnel wall next to you",
//             "Taken by suprise you dart forward past the sourceless fire. Looking back you see it remaining in place, so continue forward at your previous pace",
//             "Ten metres on from the flame, another appears as you approach and as you continue down the tunnel, more and more",
//             "You begin to feel comforted by the predictability of the strange, heatless flames",
//             "This continues until the fiftieth flame appears revealing the end of your long, walk",
//             "You stop before a giant towering black door",
//             "As you scan your eyes up the imposing facade, the white guiding flames float past you to take up places surrounding the door, allowing you to see its full size",
//             "To your surprise you see the flames start to change as they flit back and forth in the air, a movement you have come to know well",
//             "The white wisps dance about the door, illuminating its monolith somehting",
//             "The black metal of the door is twisted in and around itself like petrified vines",
//             "As you study the writhing forms, you begin to feel a sickness rising up from your core",
//             "Your eyes flow over the dark metal and a wave of darkness takes hold of you, threatening to crush you under its weight",
//             "Your eyelids begin to drop, unable to hold their own weight and you feel your knees buckle underneath you",
//             "There is a flash of light, and through half closed eyes, you see the white wisps flurrying around you, pulling your focus away from the cursed door",
//             "You feel your strength begin to return as their light shields you from the twisted image in front of you",
//             "Looking to the wall beside the door you see a large key hole, however there is no key nearby.."
//         };
//         List<string> twistedMetalForge = new List<string>
//         {
//             "You pull the two 'Twisted Black Metal Shards' from your pack and hold them in front of you",
//             "They resemble the vile door but you are unsure how that will help you",
//             "As you go to put them away, one of the wisps darts towards you and strikes you, melting into your chest ",
//             "Suddenly you feel a wave of heat building in your chest like the roar of a blacksmiths forge",
//             "It travels down your arms, and settles in your hands, where it grows more intense by the second",
//             "Your hands begin to glow red as a forge and the heat is so intense that the twisted metal in your hands begins to soften"
//         };
//         //a sequence of 1. Squeeze it tight options each with the pain growing worse
//         List<string> twistedKey = new List<string>
//         {
//             "The pain grows so much that you fear your hands will burn away",
//             "You try to release your grip, however find that your arms are locked in place",
//             "The light from the magical forge in your grip is so bright that you can see nothing else",
//             "Then, a deafening sound like a sword slicing through steel rings out and fills your ears",
//             "The burning begins to subside and the light starts to fade amd you feel yourself regain control of your limbs",
//             "You open your hands and look on to see the 'Twisted Black Metal Shards' have been reformed into a 'Twisted Black Key' still hot against your skin",
//             "You take the key over to the hole in the wall and slot it into place, using all your strength to turn it until it clicks",
//             "The stone all around you erupts with sudden shakes and might groans",
//             "You stumble back to stand in front of the accursed door, struggling to stay on your feet as the ground quakes beneath you",
//             "You risk a quick glance up at the door, finding it no longer affects you like it did before",
//             "From its very centre, the black metal begins to ripple outwards, each twist writhing accross its surface",
//             "The door splits down the middle and swings out slowly towards you",
//             "Fighting against the ever shifting ground, you begin to move forwards, towards the chamber within",
//             "A sense of calm washes over you as you venture towards what you suspect is the final challenge of your quest"
//         };
//         List<string> witheringRoom = new List<string>
//         {
//             "As you pass through the giant doorway, the ground suddenly stops shaking",
//             "You now stand within a large chamber with twisted black metal walls, writhing and shifting as if alive",
//             "Behind you the doorway is no longer there, only the same unsettling walls",
//             "There is nothing furnishing the vast room",
//             "In the floor at the centre of the room is a large metal grate from which thick green fumes rise up to the ceiling",
//             "Above you taking up most of the ceiling is a large hole leading upwards with sharp stone jutting out from its sides",
//             "On the other side of the room you can see a small break in the black metal of the wall, revealing a stone alcove",
//             "As you look on, you begin to hear a cacophony of whispers building in volume coming from all around"
//         };
//         List<string> poisonFumes = new List<string>
//         {
//             "You approach the metal grate in the chamber floor",
//             "As you get closer, you can smell the fumes rising up into the room",
//             "The smell is sharp and burns your nose and eyes",
//             "You hold your breath and get as close as you can bare",
//             "There is a small metal plate at the edge of the grate with something written on it",
//             "--Cauldron of withering blight--",
//             "##The haunting whispers are growing louder##"
//         };
//         List<string> lookUpAtHole = new List<string>
//         {
//             "You look up into the hole above while walking round the room",
//             "There is no light to be seen and no visible end to the cavity",
//             "The stones sticking out are gouged with giant scratches",
//             "As you have almost made a full circuit of the chamber, a small stone falls in front of you and clatters across the floor",
//             "Tracing its path upwards you see a large portion of rock which has been gouged so much it it only holding on by a small sliver of rock",
//             "Making sure not to walk directly underneath it, you return to where you entered the room",
//             "##The dismbodied voices are geting even louder##"
//         };
//         List<string> smallAlcove = new List<string>
//         {
//             "You cross the room, avoiding the fumes at the centre and make for the small alcove in the wall"  ,
//             "Sitting within you find a small scroll which looks like it was rolled up in a hurry"
//         };
//         List<string> finalScroll = new List<string>
//         {
//             "You unfurl the scroll and read the messily written words written on it",
//             "--THE WITHERING RITUAL--",//A THOUSAND LINES OF CODE BABY
//             "--We managed to lure the Twisted Knight here to the temple and have trapped them in enchanted bindings",
//             "--They won't hold for long though, and shadows help us when they break loose",
//             "--The time for a decision has come and even the elders now believe the ritual is our only option",
//             "--Preparations have been made and every citizen of Tash'Kar has gathered here to lend their power",
//             "--The only thing left is to finish brewing the Withering Blight",
//             "--It would have been ready by now, had we known how sensitive to fire its fumes were. Thankfully no one was too near when the torch fell off the wall and rolled over the grate",
//             "--It took a whole day to clear the rubble that was blasted loose from the ceiling. A day we could barely have spared",
//             "--The guards are bringing the captured knight to the ritual chamber now as we add the final enchantments to the cauldron",
//             "--I know somehwere in one of the upper chambers, my family are together, well away from any immediate danger",
//             "--I wish they could be with me now as I face my biggest challenge. The biggest challenge in the history of our people",
//             "--I keep telling myself I will be able to rejoin them once we have succeeded here, but none of us can be sure that this will work",
//             "--If this doesnt work, and I do not survive this day, and in the off chance someone, someday reads what I right here:",
//             "--I am Lord Agvenar, Master of Rituals and Sorcery here at the temple of Shadowstone",
//             "--My heart, is The Heart of a Sorceror and it belongs in whole to my people, the mighty and wonderful Tash'Kar",
//             "--I share my existence - mind, body and soul - with Lord Tokkshir, warrior of the Featherflight army, lover of trees",
//             "--We two shared our life with the now departed Lord Kra-naer, Shadowmaster of the Forests, who gave their life to defend our people in the war",
//             "--Our shadowborn is Kir'Tara, whisperer of Snakes and forgemaster of Swords in the southern shades",
//             "--I have lived over 3 centuries, and have seen the best and worst that has been for my people",
//             "--If I die today, know that I gave my life willingly to rid the world of its greatest threat",
//             "--Let my sacrifice be payment in part for the suffering my own creation inflicted upon this world"
//         };
//         List<string> afterFinalScroll = new List<string>
//         {
//             "SCROLLS: 5 out of 5 Objective complete",
//             "You put the scroll in your bag and ponder what you read",
//             "You wonder what happened after it was written..",
//             "Did they succeed in their ritual..",
//             "Did they all die as a result..",
//             "Why is it so quiet all of a sudden..",
//             "..",
//             ".."
//         };
//         List<string> theWitheringShade = new List<string>
//         {
//             "You turn slowly, holding your breath, to look back at the chamber behind you",
//             "The chamber is no longer empty",
//             "You come face to face with a horrifying creature, and your entire body goes cold",
//             "A face made up of hundreds of faces stares down at you, fury in every one of its many eyes",
//             "From its head, a twisted body towers up and out into the room behind",
//             "You can see at least ten gnarled limbs holding it up, each with a razor sharp claw at its tip",
//             "The creatures body is void black, and looks like twisted chords",
//             "From every inch of its surface, sprout hands, pressing out against its flesh as if to break free",
//             "Surrounding it, a thick black shadow flows like tar, clinging to its surface",
//             "Its hundreds of mouths open and begin to whisper, a sound you have become too familiar with by now",
//             "There is no way past the creature",
//             "You look up into two if its eyes and a flash of dark, twisted energy pierces your mind, filling your head with noise",
//             "In the chorus of hateful voices, you hear a name repeated over and over like a warning",
//             "£$%^%& THE %^$* WITHERING (*(**&*&%$ SHADE @:}**$£"
//         };
//         List<string> battleWin = new List<string>
//         {
//             "The creature recoils in agony letting loose a piercing shriek that shakes the room and pierces your entire body",
//             "It rights itself and makes to charge at you",
//             "It leaps halfway accross the room and readies itself to pounce again when the wall where the door used to be explodes inwards",
//             "In through the dust come a swarm of Wisps, blue, green, red and white",
//             "They encircle the Shade and fly round faster and faster, causing it to falter and swing out its vile limbs trying to swat at the entities",
//             "The Wisps glow grows bright and the Withering Shade crys out as if in pain",
//             "Shafts of bright colourful light begin to shoot out from the Shades body one after the other casting a rainbow of energy across the room",
//             "The Wisps get faster and faster, almost a blur now as the shrieks of the Shade get louder and more desperate",
//             "The screaming reaches a crescendo and hundreds of voices can be heard, crying out in pain",
//             "The Shade implodes in on itself, each limb falling in as if sucked by a void at its centre",
//             "There is loud cracking as its bones fold and break",
//             "The creature is now just a head, covered in screaming faces, but that too gets pulled inwards until all that remains is a tiny point of darkness",
//             "There is silence for a brief moment before the small void explodes outwards, sending shadows flying across the room",
//             "Wave after wave of dark energy flows outwards, smashing into you, pressing you into the wall unable to move",
//             "After what feels like an age, the waves subside allowing you to fall forward to your knees",
//             "Relief washes over you like spring water as you look up to see the creature is gone",
//             "So too are the wisps",
//             "You stand, exhausted, and limp over to where the killing blow was made",
//             "On the ground amongst the rubble, you find a small scroll. It is black as the night sky with tiny shards of colour dancing across its surface like stars",
//         };
//         List<string> witheringScroll = new List<string>
//         {
//             "You nervously open the scroll and read what lies within:",
//             "##THE WITHER AND WISP KNIGHT##",
//             "##Behold, the slayer of the Withering Shade##",
//             "##Friend of the Wandering Wisps##",
//             "##Saviour of the Tash'Kar##",
//             "As you linger on those last words, confused the scroll melts away into a mist, dark and filled with sparks of light",
//             "The mist surrounds you and lifts you off the ground",
//             "You feel an intense power rushing through your body. Strength filling you and every pain melting away",
//             "The mist solidifies around you into magnificent plate armour that looks like a galaxy of stars across the void of space",
//             "You mind becomes clear and focused, filling with information you could never in one lifetime learn",
//             "Histories of every race, every spell ever written, recipes for every food ever cooked",
//             "You can see in your mind, the great war which threatened the Tash'Kar",
//             "You see the Twisted Knights massacre",
//             "You see the centuries that have passed since",
//             "You slowly drift back towards the chamber floor and land gently on now strong and powerful legs",
//             "~~CONGRATULATIONS~~",
//             "You have slain the Withering Shade"

//         };
//         List<string> endingFork = new List<string>
//         {
//             "You make your way to leave the chamber. It has been a long time since you were home and you're eager to see your people again",
//             "Just as you are about to walk through the hole in the wall, you turn to take one last look behind you",
//             "You scan the empty room, which no longer seems as dounting as when you first entered it",
//             "The shadows against the walls dont seem so threatening now",
//             "Your eyes settle on the shadows against the far wall where stone breaks the black metal walls",
//             "The darkness seems to be..moving, swirling and twisting..",
//             "Your pulse rushes as the form starts to come together into a solid mass.."
//         };
//         //leave at once or investigate
//         List<string> theTashKar = new List<string>
//         {
//             "You draw your sword and summon powerful magic that courses up your arm into your armoured hand, sending a bright prism of light outwards",
//             "Confidently, you take a step into the room once again, ready to face whatever lies ahead",
//             "As you step closer to the writhing form, ready to take action at a moments notice, the twisting shadows dissapate, revealing the curled up crouching form of a person..",
//             "You lower your sword but keep your spell at the ready as the mysterious figure heaves themself off the floor and stands to face you",
//             "They stand tall, with eyes closed and take in a deep breath, letting it out with a sigh of relief",
//             "They are dressed in a [choose a colour] robe of thin, but heavy fabric hanging all the way to the ground",
//             "Their hands are clasped in front of them, poking out through the robe enveloped in delicate metal plates",
//             "Each finger ends in a razor sharp claw of shining silver",
//             "Their face is narrow and angled, their features ending soft points, catching any light in the room",
//             "From atop their head, thick ropes of hair flow backwards and down their back, like chords of woven silk",
//             "From the sides of their face, their ears point long and back, wide and flat like the fins of a sea creature",
//             "But perhaps the most notable feature which fills you with trepidation is their skin",
//             "Glossy black, like the midnight sky, their flesh looks like hundreds of thousands of delicate strings, twisting about each other",
//             "You cannot ignore the resemblance to the flesh of the Withering Shade, and go to once more, draw your sword",
//             "Then the being in front of you opens their eyes, and you are transfixed by their gaze",
//             "Burning white, like stars, their eyes have no pupils, just glittering colours swirling across their surface",
//             "You are hypnotised by their beauty, unable to move a muscle as they run their eyes over you",
//             "The mysterious apparition steps towards you, opens their mouth, and begins to speak in a voice like the wind through trees",
//             "--Greetings. I am Agvenar of the Tash'kar. Tell me, what has happened in this place?"
//         };
//     }

// }
