//class for each room

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
public static class RoomOne
{
    public static List<string> Description = new List<string>
    {
        "You walk in to a dark circular room, cast in dim blue light which barely reaches the shadowy wall",
        "There are small pools of water strewn accross the uneven stone floor and the air smells rancid like mold and putrid meat",
        "Covering most of the walls and floor is a thick tangle of dark moss, from which sprout glowing mushrooms",
        "Looking up, you see several magical wisps of energy, dancing through the air, glowing icy blue. Above them, you cannot see the ceiling of the room",
        "Glinting in their light is a thick dusty haze which fills air in the whole room",
        "To your left, you can make out a small alcove in the wall. Every so often, something seems to catch the light of the entities above",
        "There is a large GREEN metal door breaking the jagged round walls straight accross from you.It appears to have an image etched on to its surface, however you can't make out what it depicts",
        "In the centre of the room is a circular stone plinth, atop which sits a shallow stone bowl holding some sort of liquid, occasionally reflecting the glow from above"
    };
    public static List<string> GreenDoor = new List<string>
    {
        "You cross the dark room, damp room weaving between the sprouting mushrooms and stagnant puddles, until you're standing before the Green Metal Door",
        "Around the door the stone has been carved into a frame of gnarled root, tangled up in each other",
        "The face of the door is etched with an image of a great tree. From its trunk, leafless branches spread up and out and symetrical twisted roots wind down the door",
        "There is no handle"
    };
    public static List<string> NoticeRecess = new List<string>
    {
        "You cross the dark room, damp room weaving between the sprouting mushrooms and stagnant puddles, when something catches your eye",
        "Tucked into the bottom of the mossy wall in a corner of the room you haven't yet investigated, you spy a carved out recess previously shrouded in shadow",
        "Now however a flickering blue light emanates out into the room, which is how you noticed it",
        "Curious"
    };
    public static List<string> InvestigateRecess = new List<string>
    {
        "You make your way over to the glowing opening and crouch down to peer inside, sweeping back a curtain of draped moss",
        "Inside you find a large, mushroom somehow sprouting from the lifeless stone of the chamber floor",
        "Its cap is the deep blue of the dusk sky covered in splotches of bright, vibrant white",
        "From the edges of its colourful cap, gills drape like lace to to the ground, concealing most of its stem",
        "Atop the mushroom, you discover the source of the light, which drew you over -",
        "A single blue wisp bounces playfully up and down across its surface, sending sparks of magical light dancing across the smooth cap on each landing",
        "The sight brings a smile to your face"
    };
    public static List<string> TryTouchWisp = new List<string>
    {
        "You reach a tentative hand into the small hollow and try to touch the small curious entity",
        "As you fingers draw near, the wisp changes direction and lands its next bounce on the back of your hand",
        "It feels like the lick of a flame, but with only a gentle warmth",
        "It immediately bounces off and back to the mushroom below, continuing its whimsical bobbing"
    };
    public static List<string> UnderMushroom = new List<string>
    {
        "Hesitantly, you reach out and sweep the living filigree of the blooming mold aside",
        "The movement sends a scatter of tiny glittering specks floating out into the air",
        "Revealed beneath is a an impossible dark stem, so void of colour and light like a hole in the world",
        "You see the corner of something pocking out from behind the strange emptiness"
    };
    public static List<string> Whispers = new List<string>
    {
        "You stand up from the small alcove and turn back to the room",
        "The light emanating from above has dimmed and you look up to see the floating wisps are no longer there",
        "The only light in the room now comes from the spread of glowing fungus",
        "As if from the very walls, a sound like whispers meets your ear",
        "It sounds like a huge crowd of people, calling to you under their breath",
        "You are filled with a sense of unease"
    };
    public static List<string> ToDoorFinal = new List<string>
    {
        "You quietly creep over towards the GREEN metal door, feeling as if you are being watched",
        "You come to stand before the door and look upon it",
        "Around the door the stone has been carved into a frame of gnarled root, tangled up in each other",
        "The face of the door is etched with an image of a great tree. From its trunk, leafless branches spread up and out and symetrical twisted roots wind down the door",
        "There is no handle"
    };
    public static List<string> TryOpenDoor = new List<string>
    {
        "You lift a hand and try to push the door open but it doesn't move",
        "You place both hands on it and push even harder and still nothing",
        "As you take your hands away you notice something you hadnt before",
        "In the centre of the door, below the carved tree trunk, is a slot where there should be a root"
    };
    public static List<string> OpenDoor = new List<string>
    {
        "You retrieve the 'Ancient Root' from your pack and place it gently in the slot in the door",
        "Nothing happens",
        "Confused, you look back towards the stone plinth as if to ask what you should do",
        "Then, you feel the ground beneath your feet shaking and hear a sound like the creak of a tree bending in a storm",
        "You turn back to see the 'Ancient Root' glowing bright green. Its surface morphs as you look on into the same metal as the rest of the door",
        "The rumbling grows more intense as the root seems to melt into the door",
        "You shield your eyes from the ever brightening glow",
        "Moments pass and the ground settles once again. You hear a loud thunk",
        "You drop your hand to see no evidence that there was ever a peice missing from the now open door"
    };
    public static List<string> NextRoom = new List<string>
    {
        "You step forward through the open door into a long dark corridor",
        "As you make your way onward, a loud bang from behing takes with it any remaining light from the room behind",
        "Steadfast, you march into the darkness.."
    };
    public static List<string> AlcoveDescription = new List<string>
    {
        "You approach the small alcove in the wall and discover a small chest sitting in the shadow",
        "Its dark wood is rotting away, and is only held together by its rusted metal frame",
        "The chest is shut and there is a clasp with a keyhole on the front which can be lifted"
    };
    public static List<string> ChestDescription = new List<string>
    {
        "You reach out, hook a finger under the clasp of the small chest and attempt to flip it up",
        "It remains firmly in place at first, however with a bit more effort, you manage to move the old rusted metal",
        "As you lift the battered lid up to see what lies within, the movement proves too much for the ancient wood and the entire box disintegrates into dust",
        "Left behind on the wet stone shelf, covered in wet dust, you find 2 labeled glass vials containing mysterious liquids as well as a small, wooden box, apparently untouched by the ravages of time"
    };
    public static List<string> DraughtVitaltyGet = new List<string>
    {
        "You pick up the left most vial and peer at the label on its side",
        "++Draught of Vitality++",
        "This may be useful later on so you place it in your pack"
    };
    public static List<string> ElixirMagicGet = new List<string>
    {
        "You pick up the right most vial and read the writing scrawled on its label",
        "--Elixir of Magic",
        "You may find a use for this yet, in the pack it goes"
    };
    public static List<string> RingGet = new List<string>
    {
        "You pick up the small wooden box and flip the lid open",
        "Inside you find a pristine, golden ring, inscribed with ancient script. Set into the ring is a brilliant white gem stone flecked throughout with shards of every colour",
        "You look closer at the engaved writing and find to your surprise, that you can read it",
        "##The Sorcerers Heart##",
        "This is surely worth a lot and should keep your pockets full of gold and your home full of food for years to come were you to sell it",
        "You place the small wooden box back on the shelf and gently slide the ring on to your finger, finding it fits perfectly",
        "EQUIPPED: 'The Sorcerors Heart'",
        "A rush of energy sweeps up your arm and the stone on the ring begins to glow",
        "***YOU CAN NOW USE MAGIC***"
    };
    public static List<string> CentrePlinth = new List<string>
    {
        "You move to the centre of the room and stand before the ornate stone plinth",
        "Atop the pillar, the shallow bowl appears to contain a swirling glittery liquid",
        "Around the rim, ancient lettering is etched into the stone",
        "You can't read what it says",
        "You stop closer to stand over the liquid and to your shock, you'dont see your reflection",
        ""
    };
    public static List<string> Runes = new List<string>
    {
        "You reach out to touch one of the symbols round the edge of the bowl",
        "As you feel the carved rune under your fingers, the etching glows light blue, then fades back to dull stone"
    };
    public static List<string> MysteriousLiquid = new List<string>
    {
        "You lean closer, pearing into the mysterious billowing liquid",
        "While you still can't see your own reflection, you can suprisingly see the ceiling of the room above you",
        "Dancing across its surface, the magical blue wisps are synchronised now, all in a circle like a halo"
    };
    public static List<string> ActivatePlinth = new List<string>
    {
        "While staring into the magical glittering liquid, you run your hands round the rim of the bowl, activating each rune in turn",
        "When all the symbols are illuminated, the floating wisps in the reflection start to fly round quicker and quicker, until almost a blur of blue light",
        "The liquid in the bowl before you begins to glow also, before smoothly raising itself up into the air into a perfect spinning sphere",
        "The glow begins to fade, revealing two items floating within",
        "One looks like a small piece of wood and the other a gnarled piece of black metal"
    };
    public static List<string> PlinthItems = new List<string>
    {
        "You reach out and pluck the items from the floating ball of liquid",
        "You look down at the now dry items",
        "The first is a piece of the root of a tree, seemingly ancient but well preserved",
        "The second is a shard of twisted black metal, ice cold to the touch",
        "A sense of discomfort rises in you when you look at the latter",
        "You place both in your pack"
    };
    
}
public static class RoomTwo
{
    public static List<string> EnterGreen = new List<string>
        {
            "You make your way down the dark corridor, hearing only the tap of your boots on the stone floor",
            "The sound changes to a soft crunch as you start to make out a soft green glow up ahead",
            "You get closer and see a doorway ahead leading into a gently lit chamber",
            "You walk through the door to find yourself in a large chamber, bigger than the last"
        };
        public static List<string> Description = new List<string>
        {
            "The floor is covered in a thick, almost bouncy layer of moss and ancient rotten wood",
            "From the walls all around, thick twisted roots reach out and cross the room",
            "Accross from you, through the wooden web, you see a large RED door set into the wall"
        };
        public static List<string> Roots = new List<string>
        {
            "You step out into the room and look towards the impossibly high ceiling",
            "You look up to see the roots have broken through into the chamber all the way up to the distant ceiling",
            "Dancing and weaving in between the roots, are playful green wisps of light similar to those in the last room",
            "From where you stand you can just about make out a ledge far above you",
            "You may be able to use the roots to climb up there"
        };

}
public static class RoomThree
{

}
public static class WitheringShadeChamber
{

}
public static class EndSequence
{

}
public static class Scrolls
{
    public static List<string> One { get; } = new List<string>
    {
        "You pull the scroll free from its place in the door and unfurl it to reveal a long, handwritten message",
            "The writing is elegantly scribed, flowing across the page in flourishes",
            "It reads as follows:",
            "--The Knight of Tash'kar--",
            "--The armored figure depicted here is the mighty Knight of of the Tash'kar",
            "--We the Tash'kar are a race of noble beings who live amongst the shadows of the trees. We are well known as powerful sorcerors",
            "--If you are reading this, it is likely we have all long since parted from this world. Please read our story, and take heed",
            "--Skilled in the dangerous art of Shadowmancy, we were feared not only by our enemies, but by our closest allies as well",
            "--This fear festered in the hearts of the kingdoms of the land until one day a great war was declared against the Tash'Kar",
            "--Friend and foe alike took up arms against us, determined to drive us from this land",
            "--The war raged on for a hundred years as the now united races of the land threw their forces against our unrelenting shadow army",
            "--It seemed as though the war would never end, until we the mighty Tash'kar, sent forth our greatest hero",
            "--The result of the most powerful magic we could muster, The Knight of Tash'kar was an enchanted soldier who seemingly could not be slain",
            "--Waves of enemy soldiers fell to their dark blade as they swept through the enemy forces. No one could stand against them",
            "--Fearful for the safety of their kingdoms, the rulers of the land recalled their armies and declared forfeit",
            "--While we were satisfied with this, set on returning to a time of peace, our fearsome Knight was not..",
            "--Unbeknownst to us, the Twisted Kight left our dark forest and layed siege to the neighboring kingdom of Devarr",
            "--There were no survivors",
            "--When word of the slaughter reached the Tash'Kar Capital, we were horrified and set about preventing any further death at the dark knights hand...",
            "",
            "The story fills you with a great feeling of pain and regret",
            "You place the scroll in your pack and look to the great warrior on the stone door"//a subtle hint to the writer: Agvenar
    };
    public static List<string> Two { get; } = new List<string>
    {
        "You retrieve the item, being careful not to touch the shadowy stem and find it is a scroll",
        "You open the scroll to find sharp pointed lettering spreading across its surface. It reads:",
        "- The war rages on as it has for decades and my people are dying",
        "- No matter how much we cry for peace, the nations of the land respon only with brutality and death",
        "- Great fear lives within me for the safety of my family. For the safety of all Tash'Kar families",
        "- There must be some way to end the bloodshed before all our kingdoms lie in ruin",
        "- ",
        "- I have come here to the temple, against the wishes of my shadowties, on rumour of some plan to bring the fighting to an end",
        "- Though the Master of Rituals may protest, as Shadowmaster I take no orders except from the Elders",
        "- Though this reluctance may come from a place of care, I must lend my aid to my people and if the answer is here, then by the Void, so must I be",
        "- ",
        "- I have heard the 'great plan'..",
        "- It is a bold venture, thought up by the Master of Sorcery here at the great temple. Bold, but with a cost",
        "- In Tash'Kar history, nothing like this has ever been attempted",
        "- A great sacrifice is required. One life to save many..",
        "- A life left behind, all family forsaken,never the same again, to champion the fight against our enemies",
        "- How could we possibly ask someone to pay this price?",
        "- No one would willingly accept the Twisted fate required of them, no matter how much strength or power it came with",
        "- ",
        "- I will not stand idly by and let any Tash'Kar be chosen at random to take on the mantle of 'saviour'",
        "- No matter how much those around me protest, it is I who shall give my life for my people",
        "- This war must end. The suffering must cease. And if I must give up my very existence to see that come about, then so be it",
        "- I go now, to the ritual chamber below to face my fate",
        "- To my family, I do this for your safety",
        "- I do this, willingly, for all Tash'Kar",
        "--- Lord Tokk..",
        "",
        "The ink is smudged and you cannot make out the signature at the bottom of the scroll",
        "As you place the scroll in your pack, you hear something coming from behind you"
    };
    public static List<string> Three { get; } = new List<string>
    {

    };
    public static List<string> Four { get; } = new List<string>
    {

    };
    public static List<string> Five { get; } = new List<string>
    {
        "You unfurl the scroll and read the messily written words written on it",
            "--THE WITHERING RITUAL--",
            "--We managed to lure the Twisted Knight here to the temple and have trapped them in enchanted bindings",
            "--They won't hold for long though, and shadows help us when they break loose",
            "--The time for a decision has come and even the elders now believe the ritual is our only option",
            "--Preparations have been made and every citizen of Tash'Kar has gathered here to lend their power",
            "--The only thing left is to finish brewing the Withering Blight",
            "--It would have been ready by now, had we known how sensitive to fire its fumes were. Thankfully no one was too near when the torch fell off the wall and rolled over the grate",
            "--It took a whole day to clear the rubble that was blasted loose from the ceiling. A day we could barely have spared",
            "--The guards are bringing the captured knight to the ritual chamber now as we add the final enchantments to the cauldron",
            "--I know somehwere in one of the upper chambers, my family are together, well away from any immediate danger",
            "--I wish they could be with me now as I face my biggest challenge. The biggest challenge in the history of our people",
            "--I keep telling myself I will be able to rejoin them once we have succeeded here, but none of us can be sure that this will work",
            "--If this doesnt work, and I do not survive this day, and in the off chance someone, someday reads what I right here:",
            "--I am Lord Agvenar, Master of Rituals here at the temple of Shadowstone",
            "--My heart, is The Heart of a Sorceror and it belongs in whole to my people, the mighty and wonderful Tash'Kar",
            "--I share my existence - mind, body and soul - with Lord Tokkshir, warrior of the Featherflight army, lover of trees",
            "--We two shared our life with the now departed Lord Kra-naer, Shadowmaster of the Forests, who gave their life to defend our people in the war",
            "--Our shadowborn is Kir'Tara, whisperer of Snakes and forgemaster of Swords in the southern shades",
            "--I have lived over 3 centuries, and have seen the best and worst that has been for my people",
            "--If I die today, know that I gave my life willingly to rid the world of its greatest threat",
            "--Let my sacrifice be payment in part for the suffering my own creation inflicted upon this world"
    };
    public static List<string> witherWisp { get; } = new List<string>
    {
        "You nervously open the scroll and read what lies within:",
            "##THE WITHER AND WISP KNIGHT##",
            "##Behold, the slayer of the Withering Shade##",
            "##Friend of the Wandering Wisps##",
            "##Saviour of the Tash'Kar##",
            "As you linger on those last words, confused the scroll melts away into a mist, dark and filled with sparks of light",
            "The mist surrounds you and lifts you off the ground",
            "You feel an intense power rushing through your body. Strength filling you and every pain melting away",
            "The mist solidifies around you into magnificent plate armour that looks like a galaxy of stars across the void of space",
            "You mind becomes clear and focused, filling with information you could never in one lifetime learn",
            "Histories of every race, every spell ever written, recipes for every food ever cooked",
            "You can see in your mind, the great war which threatened the Tash'Kar",
            "You see the Twisted Knights massacre",
            "You see the centuries that have passed since",
            "You slowly drift back towards the chamber floor and land gently on now strong and powerful legs",
            "~~CONGRATULATIONS~~",
            "You have slain the Withering Shade"
    };
}