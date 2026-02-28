public static class Rooms
{
    public static bool One()
    {
        bool navigation = true;
        GameFunctions.Dialogue(RoomOne.Description);
        while(navigation)
        {           
            switch(GameFunctions.CheckOption(GameOptions.RoomOneNav))
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
                            if(
                                Characters.player.Inventory.Contains(Items.ElixirMagic)&&
                                Characters.player.Inventory.Contains(Items.DraughtVitality)&&
                                Characters.player.Mana==5
                            )
                            {
                                choosingItem=false;
                            }
                            switch(GameFunctions.CheckOption(GameOptions.ChestItemOptions))
                            {
                                case 1:
                                    if (!Characters.player.Inventory.Contains(Items.DraughtVitality))
                                    {
                                        GameFunctions.Dialogue(RoomOne.DraughtVitaltyGet);
                                        Characters.player.PickUp(Items.DraughtVitality);
                                        GameOptions.ChestItemOptions[1]="-";
                                    }
                                    break;
                                case 2:
                                    if (!Characters.player.Inventory.Contains(Items.ElixirMagic))
                                    {
                                        GameFunctions.Dialogue(RoomOne.ElixirMagicGet);
                                        Characters.player.PickUp(Items.ElixirMagic);
                                        GameOptions.ChestItemOptions[2]="-";
                                    }
                                    break;
                                case 3:
                                    if (Characters.player.Mana==0)
                                    {
                                        GameFunctions.Dialogue(RoomOne.RingGet);
                                        Characters.player.Mana+=5;
                                        GameOptions.MenuOptions[2]="2. SpellBook";
                                        GameOptions.ChestItemOptions[3]="-";
                                    }
                                    break;
                                case 0:
                                    choosingItem=false;
                                    break;
                            }
                        }
                    }
                    break;
                case 2://Green Door
                    if (Characters.player.Inventory.Contains(Items.AncientRoot))
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
                                nA=GameFunctions.CheckOption(GameOptions.TakeScrollTwo);
                                GameFunctions.Dialogue(Scrolls.Two);
                                Console.WriteLine($"SCROLLS: {Characters.player.NewScroll()} of 5 collected!");
                                foundScroll=true;
                            }
                        }
                        GameFunctions.Dialogue(RoomOne.Whispers);
                        nA=GameFunctions.CheckOption(GameOptions.CreepToDoor);
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
                            navigation=false;
                            return true;
                        }
                    }
                break;
                case 3:
                    bool runeGlow=false;
                    bool atPlinth=true;
                    GameFunctions.Dialogue(RoomOne.CentrePlinth);
                    while (atPlinth)
                    {
                        if (GameFunctions.CheckOption(GameOptions.PlinthOptions) == 0)
                        {
                            runeGlow=true;
                            GameFunctions.Dialogue(RoomOne.Runes);
                        }
                        else
                        {
                            GameFunctions.Dialogue(RoomOne.MysteriousLiquid);
                            if (runeGlow&&!Characters.player.Inventory.Contains(Items.AncientRoot))
                            {
                                int nA = GameFunctions.CheckOption(GameOptions.LiquidIfRuned);
                                GameFunctions.Dialogue(RoomOne.ActivatePlinth);
                                nA=GameFunctions.CheckOption(GameOptions.TakeRootAndShard);
                                GameFunctions.Dialogue(RoomOne.PlinthItems);
                                Characters.player.PickUp(Items.AncientRoot);
                                Characters.player.PickUp(Items.TwistedBlackShardOne);
                                atPlinth=false;
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
                if (GameFunctions.CheckOption(GameOptions.TryRed )== 0)
                {
                    GameFunctions.Dialogue(RoomTwo.TryRed);
                }
                if (Characters.player.Inventory.Contains(Items.FieryGemstone))
                {
                    int nA = GameFunctions.CheckOption(GameOptions.TryGemstone);
                    GameFunctions.Dialogue(RoomTwo.RedSerpent);
                    Characters.player.Use(Items.FieryGemstone);
                    nA=GameFunctions.CheckOption(GameOptions.RedHandle);
                    GameFunctions.Dialogue(RoomTwo.RedHandle);
                    nA=GameFunctions.CheckOption(GameOptions.ThroughRed);
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
        return true;
    }
}