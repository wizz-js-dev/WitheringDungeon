namespace WitheringDungeon;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(Characters.player.SpellBook.Count);
        //Gets player data and assigns to character object
        Console.WriteLine("Greetings adventurer! Prey tell, what is your name?");
        Characters.player.Name=Console.ReadLine();
        Console.WriteLine("How strong are you?");
        Characters.player.StatAssign(Console.In);

        //Writes to console: Intro and backstory
        GameFunctions.Dialogue(Intro.history);
        //what do you do take scroll or ignore
        if (GameFunctions.CheckOption(GameOptions.TakeScrollOne) == 0)
        {
            GameFunctions.Dialogue(Scrolls.One);
        }
        //Go through door or run away
        if (GameFunctions.CheckOption(GameOptions.EnterDungeon)!=0)
        {
            GameFunctions.Dialogue(Intro.Escape);
        }
        else
        {
            //Enter room 1
            //Do i still use separate methods for each room? yes
            //return bool, if true next room if false end game
            bool gamePlay=true;
            while (gamePlay)
            {
                gamePlay=Rooms.One();
                if (gamePlay)
                {
                    Console.WriteLine("You move to the next room. Thats all ive done so far");
                    gamePlay=false;
                }
                //if(gamePlay){gamePlay=RoomTwo};
                //if(gamePlay){gamePlay=RoomThree};
                //if(gamePlay){gamePlay=WitheringDungeon};
            }
        }
        
    }
}