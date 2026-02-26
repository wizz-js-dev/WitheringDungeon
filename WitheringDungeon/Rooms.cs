public static class Rooms
{
    public static bool One()
    {
        bool roomOptions = true;
        GameFunctions.Dialogue(RoomOne.Description);
        while(roomOptions)
        {           
            switch(GameFunctions.CheckOption(GameOptions.RoomOneNav))
            {
                case 0://open menu
                Console.WriteLine("Havent reworked the menu yet");
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
                    GameFunctions.Dialogue(RoomOne.GreenDoor);
                    if (GameFunctions.CheckOption(GameOptions.TryDoor) == 0)
                    {
                        GameFunctions.Dialogue(RoomOne.TryOpenDoor);
                        if (Characters.player.Inventory.Contains(Items.AncientRoot))
                        {
                            int nA = GameFunctions.CheckOption(GameOptions.UseRoot);
                            GameFunctions.Dialogue(RoomOne.OpenDoor);
                            roomOptions=false;
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
    
}