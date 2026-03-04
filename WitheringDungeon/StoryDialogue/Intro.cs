public static class Intro
{
    public static List<string> history = new List<string>
        {
            "You have travelled a great distance in search of 'The scrolls of Tash'kar', in order to bring peace to your homeland!",
            "You faced many trials on your journey, won many battles and escaped a great many dangers!",
            "All you have been through has led you here, to your final destination, the Withering Dungeon, wherin, you are told, 'The Scrolls of Tash'Kar' were hidden centuries ago to be retrieved when war once again threatened to ruin the land",
            "Days have passed since you entered the dungeon, venturing deeper and deeper in to the depths of the earth, steadfast in your search.",
            "You now stand before a great stone door standing slightly ajar, its face emblazened with carving of a warrior, sword in one hand, the other raised above is head surrounded by swirls of magic",
            "Around the door, carved into the cold dark stone, are many warnings in every language of the land, some so ancient you barely recognise them!",
            "Each warning reads the same, be it artfully carved or hurriedly scratched in to the stone.",
            "===Turn Back! DEATH Lies in wait within==",
            "====Turn Back! DEATH Lies in wait within===",
            "=====Turn Back! DEATH Lies in wait within====",
            "You look closer at the carving on the door and notice a small scroll, tucked between two outcroppings of metal"
        };
    public static List<string> Escape = new List<string>
        {
            $"You look at the warnings on the door and are filled with dread! 'Peace is overrated' you think to yourself.'Who doesnt love a good war!' Perhaps instead of becoming {Characters.player.Name} the Brave, or {Characters.player.Name}, Saviour of the Lands, you could become {Characters.player.Name.ToUpper()} the great war hero.{Characters.player.Name.ToUpper()} the Vanquisher!",
            $"Or perhaps you are just {Characters.player.Name.ToLower()} the cowardly. Forgotten to time as war ravages the land.",
            "You turn away from the door and make to leave the dungeon when you hear soft whispers like scratches on stone coming from the slightly open door behind you",
            "You barely have a moment to turn before darkness surrounds you and fills you, icy cold and sharp",
            "You die a cowardly death!"
        };
}