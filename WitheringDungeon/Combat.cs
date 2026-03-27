public class Combat
{
    public static bool Start(Character player, Character opponent)
    {
        List<Character> turn = new List<Character>{player,opponent};
        int turnCounter = 1;
        bool combat=true;
        bool defend=false;
        bool dodge=false;
        int dodgeBonus=0;
        GameFunctions.Dialogue(WitheringShadeChamber.FightStart);
        while (combat)
        {
            bool choosingAction=true;
            if (turn[0] == Characters.player)
            {
                choosingAction=true;
                Console.WriteLine($"TURN: {turn[0].Name}");
                if (defend == true){
                    defend=false;
                    turn[0].Defence-=Weapons.BrokenShield.Damage;
                }
                if (dodge == true)
                {
                    dodge=false;
                    turn[0].Evasiveness-=dodgeBonus;
                    dodgeBonus=0;
                }
                while (choosingAction)
                {
                    switch (GameFunctions.CheckOption(GameOptions.CombatChoices))
                    {
                        case 0://weapon
                        string[] weapons=new string[turn[0].Equipped.Count];
                        for(int i = 0; i < weapons.Length; i++)
                            {
                                weapons[i]=$"{i}. {turn[0].Equipped[i].Name}";
                            }
                        int choice = GameFunctions.CheckOption(weapons);
                        if(turn[0].Equipped[choice].Type != "shield")
                            {
                                turn[0].AttackWith(turn[0].Equipped[choice],turn[1]);
                            }
                        else
                            {
                                defend=true;
                                Console.WriteLine(turn[0].Equipped[choice].Sequence);
                                turn[0].Defence+=turn[0].Equipped[choice].Damage;
                            }
                            choosingAction=false;
                        break;
                        case 1://spell
                        string[] spells=new string[turn[0].SpellBook.Count];
                        for(int i = 0; i < spells.Length; i++)
                            {
                                spells[i]=$"{i}. {turn[0].SpellBook[i].Name}";
                            }
                        Spell spellChoice = new Spell(" ",0," ",0," "," ");
                        bool canCast=false;
                            while (!canCast)
                            {
                                spellChoice = turn[0].SpellBook[GameFunctions.CheckOption(spells)];
                                if (spellChoice.Mana < turn[0].Mana)
                                {
                                    canCast=true;
                                }
                                else
                                {
                                    Console.WriteLine($"You dont have enough Mana to cast {spellChoice.Name}, choose another spell!");
                                }
                            }
                        
                        turn[0].Cast(spellChoice,turn[1]);
                        choosingAction=false;
                        break;
                        case 2://item
                        string[] items=new string[turn[0].Inventory.Count];
                        for (int i = 0; i < items.Length; i++)
                            {
                                items[i]=$"{i}. {turn[0].Inventory[i].Name}";
                            }
                            bool choosingItem = true;
                            while (choosingItem)
                            {
                                int itemChoice = GameFunctions.CheckOption(items);
                                if (turn[0].Inventory[itemChoice] is UseableItem)
                                {
                                    UseableItem item = (UseableItem)turn[0].Inventory[itemChoice];
                                    turn[0].Restore(item);
                                    choosingItem=false;
                                }//this bit needs testing
                                else
                                {
                                    Console.WriteLine($"{turn[0].Inventory[itemChoice].Name} isn't a useable item, please pick another!");
                                }
                            }
                        choosingAction=false;
                        break;
                        case 3://dodge
                            if (GameFunctions.D20Roll() > 12)
                            {
                                dodgeBonus=turn[0].Speed/3;
                            }
                        turn[0].Evasiveness+=dodgeBonus;
                        Console.WriteLine("Light on your feet, you ready yourself for the next attack, hoping to jump out of the way");
                        choosingAction=false;
                        break;
                    }
                }
            }
            //checks if WS dead yet
            if (turn[1].Health < 5)
            {
                combat=false;
                return true;
            } else
            {
                GameFunctions.NextTurn(turn);
            }
            if (turn[0] == Characters.witheringShade)
            {
                Console.WriteLine($"TURN: {turn[0].Name}");
                Console.ReadLine();
                switch (turnCounter)
                {
                    case 1:
                    case 2:
                    case 4:
                    turn[0].AttackWith(Weapons.TwistedLimb,turn[1]);
                    Console.ReadLine();
                    break;
                    case 3:
                    turn[0].Cast(Spells.EncapsulatingShadow,turn[1]);
                    Console.ReadLine();
                    break;
                    case 5:
                    turn[0].Cast(Spells.WitheringShriek,turn[1]);
                    Console.ReadLine();
                    break;
                }
                turnCounter++;
                if (turnCounter > 5)
                {
                    turnCounter=1;
                }
            }
            if (turn[1].Health < 1)
            {
                combat=false;
                return false;
            } else
            {
                GameFunctions.NextTurn(turn);
            }
            
        }
        return true;
    }
        
}