public static class Rooms
{
    public static bool One()
    {
        bool navigation = true;
        GameFunctions.Dialogue(RoomOne.Description);
        while (navigation)
        {
            switch (GameFunctions.CheckOption(GameOptions.RoomOneNav))
            {
                case 0://open menu
                    if (!GameFunctions.Menu())
                    {
                        return false;
                    }
                    break;
                case 1://Alcove
                    GameFunctions.Dialogue(RoomOne.AlcoveDescription);
                    if (GameFunctions.CheckOption(GameOptions.ChestOptions) == 0)
                    {
                        GameFunctions.Dialogue(RoomOne.ChestDescription);
                        bool choosingItem = true;
                        while (choosingItem)
                        {
                            if (
                                Characters.player.Inventory.Contains(Items.ElixirMagic) &&
                                Characters.player.Inventory.Contains(Items.DraughtVitality) &&
                                Characters.player.Mana == 5
                            )
                            {
                                choosingItem = false;
                            }
                            switch (GameFunctions.CheckOption(GameOptions.ChestItemOptions))
                            {
                                case 1:
                                    if (!Characters.player.Inventory.Contains(Items.DraughtVitality))
                                    {
                                        GameFunctions.Dialogue(RoomOne.DraughtVitaltyGet);
                                        Characters.player.PickUp(Items.DraughtVitality);
                                        GameOptions.ChestItemOptions[1] = "-";
                                    }
                                    break;
                                case 2:
                                    if (!Characters.player.Inventory.Contains(Items.ElixirMagic))
                                    {
                                        GameFunctions.Dialogue(RoomOne.ElixirMagicGet);
                                        Characters.player.PickUp(Items.ElixirMagic);
                                        GameOptions.ChestItemOptions[2] = "-";
                                    }
                                    break;
                                case 3:
                                    if (Characters.player.Mana == 0)
                                    {
                                        GameFunctions.Dialogue(RoomOne.RingGet);
                                        Characters.player.Mana += 5;
                                        GameOptions.MenuOptions[2] = "2. SpellBook";
                                        Characters.player.Learn(Spells.EnergyBlast);
                                        GameOptions.ChestItemOptions[3] = "-";
                                    }
                                    break;
                                case 0:
                                    choosingItem = false;
                                    break;
                            }
                        }
                    }
                    break;
                case 2://Green Door
                    if (Characters.player.Inventory.Contains(Items.AncientRoot) && (Characters.player.Mana > 0))
                    {
                        GameFunctions.Dialogue(RoomOne.NoticeRecess);
                        int nA = GameFunctions.CheckOption(GameOptions.InvestigateRecess);
                        GameFunctions.Dialogue(RoomOne.InvestigateRecess);
                        bool foundScroll = false;
                        while (!foundScroll)
                        {
                            if (GameFunctions.CheckOption(GameOptions.InvestigateMushroom) == 0)
                            {
                                GameFunctions.Dialogue(RoomOne.TryTouchWisp);
                            }
                            else
                            {
                                GameFunctions.Dialogue(RoomOne.UnderMushroom);
                                nA = GameFunctions.CheckOption(GameOptions.TakeScrollTwo);
                                GameFunctions.Dialogue(Scrolls.Two);
                                Console.WriteLine($"SCROLLS: {Characters.player.NewScroll()} of 5 collected!");
                                foundScroll = true;
                            }
                        }
                        GameFunctions.Dialogue(RoomOne.Whispers);
                        nA = GameFunctions.CheckOption(GameOptions.CreepToDoor);
                        GameFunctions.Dialogue(RoomOne.ToDoorFinal);
                    }
                    else
                    {
                        GameFunctions.Dialogue(RoomOne.GreenDoor);
                    }
                    if (GameFunctions.CheckOption(GameOptions.TryDoor) == 0)
                    {
                        GameFunctions.Dialogue(RoomOne.TryOpenDoor);
                        if (Characters.player.Inventory.Contains(Items.AncientRoot))
                        {
                            int nA = GameFunctions.CheckOption(GameOptions.UseRoot);
                            Characters.player.Use(Items.AncientRoot);
                            GameFunctions.Dialogue(RoomOne.OpenDoor);
                            GameFunctions.Dialogue(RoomOne.NextRoom);
                            navigation = false;
                            return true;
                        }
                    }
                    break;
                case 3:
                    bool runeGlow = false;
                    bool atPlinth = true;
                    GameFunctions.Dialogue(RoomOne.CentrePlinth);
                    while (atPlinth)
                    {
                        if (GameFunctions.CheckOption(GameOptions.PlinthOptions) == 0)
                        {
                            runeGlow = true;
                            GameFunctions.Dialogue(RoomOne.Runes);
                        }
                        else
                        {
                            GameFunctions.Dialogue(RoomOne.MysteriousLiquid);
                            if (runeGlow && !Characters.player.Inventory.Contains(Items.AncientRoot))
                            {
                                int nA = GameFunctions.CheckOption(GameOptions.LiquidIfRuned);
                                GameFunctions.Dialogue(RoomOne.ActivatePlinth);
                                nA = GameFunctions.CheckOption(GameOptions.TakeRootAndShard);
                                GameFunctions.Dialogue(RoomOne.PlinthItems);
                                Characters.player.PickUp(Items.AncientRoot);
                                Characters.player.PickUp(Items.TwistedBlackShardOne);
                                atPlinth = false;
                            }
                        }
                    }

                    break;

            }
        }
        return true;
    }
    public static bool Two()
    {
        GameFunctions.Dialogue(RoomTwo.EnterGreen);
        GameFunctions.Dialogue(RoomTwo.Description);
        bool navigation = true;
        while (navigation)
        {
            switch (GameFunctions.CheckOption(GameOptions.RoomTwoNav))
            {
                case 0://Menu
                    if (!GameFunctions.Menu())
                    {
                        return false;
                    }
                    break;
                case 1://Roots
                    GameFunctions.Dialogue(RoomTwo.Roots);
                    if (GameFunctions.CheckOption(GameOptions.ClimbRoots) == 0)
                    {
                        if (!Characters.player.Inventory.Contains(Items.FieryGemstone))
                        {
                            Puzzles.RootJumping();
                        }
                        else
                        {
                            GameFunctions.Dialogue(RoomTwo.AlreadyClimbed);
                        }

                    }
                    break;
                case 2://Red Door
                    GameFunctions.Dialogue(RoomTwo.RedDoor);
                    if (GameFunctions.CheckOption(GameOptions.TryRed) == 0)
                    {
                        GameFunctions.Dialogue(RoomTwo.TryRed);
                    }
                    if (Characters.player.Inventory.Contains(Items.FieryGemstone))
                    {
                        int nA = GameFunctions.CheckOption(GameOptions.TryGemstone);
                        GameFunctions.Dialogue(RoomTwo.RedSerpent);
                        Characters.player.Use(Items.FieryGemstone);
                        nA = GameFunctions.CheckOption(GameOptions.RedHandle);
                        GameFunctions.Dialogue(RoomTwo.RedHandle);
                        nA = GameFunctions.CheckOption(GameOptions.ThroughRed);
                        GameFunctions.Dialogue(RoomTwo.LeaveGreen);
                        return true;
                    }
                    break;
            }
        }
        return true;
    }
    public static bool Three()
    {
        GameFunctions.Dialogue(RoomThree.EnterRedRoom);
        bool navigation = true;
        while (navigation)
        {
            switch (GameFunctions.CheckOption(GameOptions.RoomThreeNav))
            {
                case 0://Menu
                    if (!GameFunctions.Menu())
                    {
                        return false;
                    }
                    break;
                case 1://Chasm
                    GameFunctions.Dialogue(RoomThree.InvestigateChasm);
                    if (GameFunctions.CheckOption(GameOptions.TryCross) == 0)
                    {
                        GameFunctions.Dialogue(RoomThree.TryWall);
                        //Add the scroll discovery here somehow
                    }
                    break;
                case 2://Crystals
                    GameFunctions.Dialogue(RoomThree.InvestigateCrystals);
                    int nA = GameFunctions.CheckOption(GameOptions.Jump);
                    GameFunctions.Dialogue(RoomThree.JumpForCrystals);
                    nA = GameFunctions.CheckOption(GameOptions.TryMagic);
                    GameFunctions.Dialogue(RoomThree.WhichCrystal);
                    nA = GameFunctions.CheckOption(GameOptions.FirstCrystal);
                    GameFunctions.Dialogue(RoomThree.AttackFirstCrystal);
                    if (GameFunctions.CheckOption(GameOptions.CrystalPuzzle) == 0)
                    {
                        Puzzles.CrystalPuzzle();
                        navigation = false;
                    }
                    break;
            }
        }
        int na = GameFunctions.CheckOption(GameOptions.Jump);
        GameFunctions.Dialogue(RoomThree.PlatformOne);
        na = GameFunctions.CheckOption(GameOptions.Jump);
        GameFunctions.Dialogue(RoomThree.PlatformTwo);
        na = GameFunctions.CheckOption(GameOptions.TryMagic);
        GameFunctions.Dialogue(RoomThree.PrizeCrystal);
        //redo below to be less repetative?
        na = GameFunctions.CheckOption(GameOptions.TakeSword);
        GameFunctions.Dialogue(RoomThree.RedSword);
        Characters.player.Equip(Weapons.SerpentsFang);
        na = GameFunctions.CheckOption(GameOptions.TakePage);
        GameFunctions.Dialogue(RoomThree.GlowingPage);
        Characters.player.Learn(Spells.DragonsBreath);
        na = GameFunctions.CheckOption(GameOptions.TakeKey);
        GameFunctions.Dialogue(RoomThree.BlackKey);
        Characters.player.PickUp(Items.PlainBlackKey);

        bool running = false;
        while (!running)
        {
            if (GameFunctions.CheckOption(GameOptions.Run) == 0)
            {
                if (!GameFunctions.Menu())
                {
                    return false;
                }
            }
            else
            {
                running = true;
            }
        }
        GameFunctions.Dialogue(RoomThree.RunToDoor);
        Characters.player.PickUp(Items.TwistedBlackShardThree);
        Characters.player.Use(Items.PlainBlackKey);
        GameFunctions.Dialogue(RoomThree.EscapeRed);
        return true;
    }
    public static bool Corridor()
    {
        GameFunctions.Dialogue(ForeverCorridor.EnterCorridor);
        for (int i = 0; i < 2; i++)
        {
            if (GameFunctions.CheckOption(GameOptions.TryTwistedDoor) == 0)
            {
                GameFunctions.Dialogue(ForeverCorridor.SpellOnDoor);
            }
            else
            {
                GameFunctions.Dialogue(ForeverCorridor.SwordOnDoor);
            }
        }
        GameFunctions.CheckOption(GameOptions.TryTwistedDoorOther);
        GameFunctions.Dialogue(ForeverCorridor.PackWisp);
        GameFunctions.CheckOption(GameOptions.WhatWisp);
        GameFunctions.Dialogue(ForeverCorridor.WispConvo);
        GameFunctions.CheckOption(GameOptions.OpenPack);
        GameFunctions.Dialogue(ForeverCorridor.LookInBag);
        foreach (Item item in Characters.player.Inventory)
        {
            if (item.Name.Contains("Twisted"))
            {
                Console.WriteLine($"{item.Name.ToUpper()}{Environment.NewLine}");
            }
            else
            {
                Console.WriteLine($"{item.Name}{Environment.NewLine}");
            }

        }
        GameFunctions.CheckOption(GameOptions.TakeShards);
        GameFunctions.Dialogue(ForeverCorridor.TwistedMetalForge);
        foreach (string line in ForeverCorridor.Forging)
        {
            GameFunctions.CheckOption(GameOptions.HoldTighter);
            Console.WriteLine(line);
        }
        GameFunctions.CheckOption(GameOptions.Release);
        GameFunctions.Dialogue(ForeverCorridor.TwistedKey);
        GameFunctions.CheckOption(GameOptions.OpenBlack);
        GameFunctions.Dialogue(ForeverCorridor.OpenBlackDoor);
        return true;
    }
    public static bool Final()
    {
        GameFunctions.Dialogue(WitheringShadeChamber.Enter);
        bool navigation = true;
        bool[] haveLookedAround = new bool[2];
        while (navigation)
        {
            switch (GameFunctions.CheckOption(GameOptions.WitherNav))
            {
                case 0://Grate
                    GameFunctions.Dialogue(WitheringShadeChamber.Grate);
                    haveLookedAround[0] = true;
                    break;
                case 1://Hole
                    GameFunctions.Dialogue(WitheringShadeChamber.CeilingHole);
                    haveLookedAround[0] = true;
                    break;
                case 2://shelf
                    if (!haveLookedAround[0] || !haveLookedAround[1])
                    {
                        GameFunctions.Dialogue(WitheringShadeChamber.DoubleChk);
                    }
                    else
                    {
                        navigation=false;
                    }
                    break;
            }
            GameFunctions.Dialogue(WitheringShadeChamber.Shelf);
            GameFunctions.CheckOption(GameOptions.LastScroll);
            GameFunctions.Dialogue(Scrolls.Five);
            Console.WriteLine($"SCROLLS: {Characters.player.Scrolls} out of 5 collected!");
            GameFunctions.Dialogue(WitheringShadeChamber.AfterScroll);
            GameFunctions.CheckOption(GameOptions.Turn);
            //HERE WE GO BABEY!
            GameFunctions.Dialogue(WitheringShadeChamber.TheWitheringShade);
            GameFunctions.CheckOption(GameOptions.Fight);
            if (Combat.Start(Characters.player, Characters.witheringShade))
            {
                //final fight sequence
                GameFunctions.Dialogue(WitheringShadeChamber.AlmostDead);
                GameFunctions.CheckOption(GameOptions.Fire);
                GameFunctions.Dialogue(WitheringShadeChamber.FireFumes);
                GameFunctions.CheckOption(GameOptions.Shoot);
                GameFunctions.Dialogue(WitheringShadeChamber.ArrowRock);
                GameFunctions.CheckOption(GameOptions.Finish);
                GameFunctions.Dialogue(WitheringShadeChamber.BattleWin);
                GameFunctions.CheckOption(GameOptions.FinalScroll);
                GameFunctions.Dialogue(Scrolls.WitherWisp);
                GameFunctions.CheckOption(GameOptions.Leave);
                GameFunctions.Dialogue(WitheringShadeChamber.EndingFork);
                if (GameFunctions.CheckOption(GameOptions.FinalFork) == 1)
                {
                    return true;
                }
                else
                {
                    GameFunctions.Dialogue(WitheringShadeChamber.TheTashKar);
                    return true;
                }

            }
            else
            {
                //you died
                Console.WriteLine("You died. Better luck next time!");
                return false;
            }
        }
        return true;//change when decide post game
    }
    public static void DemoMode()
    {
        Characters.player.Learn(Spells.DragonsBreath);
        Characters.player.Learn(Spells.EnergyBlast);
        Characters.player.Equip(Weapons.FeatherFlight);
        Characters.player.Equip(Weapons.SerpentsFang);
        Characters.player.PickUp(Items.DraughtVitality);
        Characters.player.PickUp(Items.TwistedBlackShardOne);
        Console.ReadLine();
        Console.WriteLine("Welcome to the 'Withering Dungeon' Demo");
        Console.WriteLine("Press ENTER to continue..");

        // Console.ReadLine();
        Console.ReadLine();
        Console.WriteLine("Greetings adventurer! Prey tell, what is your name?");
        Characters.player.NameAssign(Console.ReadLine()!);
        Console.WriteLine("And, how strong are you?");
        Console.ReadLine();
        Characters.player.StatAssign(Console.In);
        Console.ReadLine();
        Console.WriteLine("0. Open The Menu");
        Console.ReadLine();
        Characters.player.Mana += 10;
        GameOptions.MenuOptions[2] = "2. SpellBook";

        GameFunctions.Menu();
        Console.ReadLine();
        GameFunctions.Dialogue(Demo.Crystals);
        Puzzles.CrystalPuzzle();
        Console.WriteLine("You have completed the demo. Thank you for playing!!");
    }
}