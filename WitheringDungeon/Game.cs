public static class Game{
    public static void Play()
    {
        //When project done, remove the dev cheat options in the puzzles 
        //Gets player data and assigns to character object
        Console.WriteLine("Greetings adventurer! Prey tell, what is your name?");
        Characters.player.NameAssign(Console.ReadLine()!);
        Console.WriteLine("How strong are you?");
        Characters.player.StatAssign(Console.In);

        //Writes to console: Intro and backstory
        GameFunctions.Dialogue(Intro.history);
        //what do you do take scroll or ignore
        if (GameFunctions.CheckOption(GameOptions.TakeScrollOne) == 0)
        {
            GameFunctions.Dialogue(Scrolls.One);
            Console.WriteLine($"SCROLLS: {Characters.player.NewScroll()} out of 5 collected");
        }
        //Go through door or run away
        if (GameFunctions.CheckOption(GameOptions.EnterDungeon)!=0)
        {
            GameFunctions.Dialogue(Intro.Escape);
        }
        else
        {//All gameplay happens in here
            //Enter room
            //return bool, if true next room if false end game
            bool gamePlay=true;
            while (gamePlay)
            {
                gamePlay=Rooms.One();
                if(gamePlay){gamePlay=Rooms.Two();}
                if(gamePlay){gamePlay=Rooms.Three();}
                if(gamePlay){gamePlay=Rooms.Corridor();}
                if(gamePlay){gamePlay=Rooms.Final();}
                if (gamePlay)
                {
                    GameFunctions.Dialogue(EndSequence.Thanks);
                    gamePlay=false;
                }
            }
        }
        
    }
}