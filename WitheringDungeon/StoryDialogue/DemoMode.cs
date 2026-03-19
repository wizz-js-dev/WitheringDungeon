public static class Demo
{
    public static List<string> Crystals = new List<string>
    {
        "Crystal Puzzle Demo",
        "You, the player, are presented with 4 floating Crystals",
        "They are roughly the size of a small shield, each cut into a different shape",
        "The YELLOW crystal resembles an anvil with a hammer resting on its surface",
        "The PURPLE, a crescent moon",
        "The ORANGE, a rounded flame",
        "And the WHITE, a shield with a sword across it",
        "Each Crystal controls various plaforms over the great Chasm",
        "PLATFORM: '|||||'",
        "EMPTY SPACE: '_____'",
        "Choose a crystal to cast 'Energy Blast' on to solve the puzzle"
    };
    public static void CombatDemo()
    {
        Characters.player.Name="Wizz";
        Characters.player.Attack=10;
        Characters.player.Mana=10;
        Characters.player.Health=100;
        Characters.player.Defence=10;
        Characters.player.Speed=10;
        Characters.player.Evasiveness=10;
        Characters.player.Equip(Weapons.BrokenShield);
        Characters.player.Equip(Weapons.FeatherFlight);
        Characters.player.Equip(Weapons.SerpentsFang);
        Characters.player.Learn(Spells.EnergyBlast);
        Characters.player.Learn(Spells.DragonsBreath);
        Characters.player.PickUp(Items.DraughtVitality);
        Characters.player.PickUp(Items.ElixirMagic);
        
        Characters.witheringShade.Attack=10;
        Characters.witheringShade.Defence=10;
        Characters.witheringShade.Speed=10;
        Characters.witheringShade.Evasiveness=10;
        Characters.witheringShade.Mana=100;

        if (Combat.Start(Characters.player, Characters.witheringShade))
        {
            Console.WriteLine($"{Characters.witheringShade.Name} dies");
        }
        else
        {
            Console.WriteLine($"{Characters.player.Name} dies");
        }

    }
}