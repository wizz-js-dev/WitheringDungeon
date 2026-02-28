public static class Puzzles
{
    public static void RootJumping()
    {
        // On way back down, small hidden shelf in wall, scroll three
        bool climbingStageOne = true;
        GameFunctions.Dialogue(RoomTwo.BeginClimb);
        while (climbingStageOne)
        {
            if (GameFunctions.CheckOption(GameOptions.JumpingChoices) == 1)
            {
                GameFunctions.Dialogue(RoomTwo.JumpSuccessButNextFail);
                int nA=GameFunctions.CheckOption(GameOptions.Jump);
                GameFunctions.Dialogue(RoomTwo.JumpFail);
            }
            else
            {
                GameFunctions.Dialogue(RoomTwo.JumpSuccess);
                if (GameFunctions.CheckOption(GameOptions.JumpingChoices) == 0)
                {
                    GameFunctions.Dialogue(RoomTwo.JumpSuccessButNextFail);
                    int nA=GameFunctions.CheckOption(GameOptions.Jump);
                    GameFunctions.Dialogue(RoomTwo.JumpFail);
                }
                else
                {
                    GameFunctions.Dialogue(RoomTwo.JumpSuccess);
                    int nA=GameFunctions.CheckOption(GameOptions.JumpingChoices);
                    GameFunctions.Dialogue(RoomTwo.JumpSuccess);
                    GameFunctions.Dialogue(RoomTwo.NextIsLedge);
                    nA=GameFunctions.CheckOption(GameOptions.Jump);
                    GameFunctions.Dialogue(RoomTwo.JumpToLedge);
                    Characters.player.Equip(Weapons.FeatherFlight);
                    climbingStageOne=false;
                }
            }
        }
        bool climbingStage2 = true;
        bool result = true;
        int level = 0;
        while (climbingStage2)
        {
            Console.WriteLine($"Level: {level}");
            int nextJump = GameFunctions.CheckOption(GameOptions.JumpingChoices);
            switch (level)
            {
                case 0:
                    result = nextJump == 0 ? false : true;
                    break;
                case 1:
                    result = nextJump == 0 ? true : false;
                    break;
                case 2:
                    result = nextJump == 0 ? false : true;
                    break;
                case 3:
                    result = nextJump == 0 ? false : true;
                    break;
                case 4:
                    result = nextJump == 0 ? true : false;
                    break;
                case 5:
                    result = nextJump == 0 ? true : false;
                    break;
            }
            Console.WriteLine($"Result: {result}");
            if (level < 5)
            {
                if (result)
                {
                    level++;
                    GameFunctions.Dialogue(RoomTwo.JumpSuccess);
                }
                else
                {
                    GameFunctions.Dialogue(RoomTwo.JumpFailStage2);
                    level = 0;
                }
            }
            else
            {
                if (result)
                {
                    GameFunctions.Dialogue(RoomTwo.ToSecondLedge);
                    Characters.player.PickUp(Items.FieryGemstone);
                    Characters.player.PickUp(Items.TwistedBlackShardTwo);
                    climbingStage2 = false;
                }
                else
                {
                    GameFunctions.Dialogue(RoomTwo.JumpFailStage2);
                    level = 0;
                }
            }
        }
        //climb down
        GameFunctions.Dialogue(RoomTwo.LeaveSecondLedge);
        int na = GameFunctions.CheckOption(GameOptions.ClimbDown);
        GameFunctions.Dialogue(RoomTwo.ClimbDown);
        if (GameFunctions.CheckOption(GameOptions.GrabSatchel) == 0)
        {
            GameFunctions.Dialogue(RoomTwo.LeatherSatchel);
            GameFunctions.Dialogue(Scrolls.Three);
            Console.WriteLine($"{Characters.player.NewScroll()} of 5 collected!");
            GameFunctions.Dialogue(RoomTwo.ContinueDown);
            na = GameFunctions.CheckOption(GameOptions.Jump);
            GameFunctions.Dialogue(RoomTwo.JumpToFloor);
            return;
        }

    }
}