//class for each room

using System.Security;

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
            "You look up to see the roots have broken through into the chamber all the way up the room",
            "Dancing and weaving in between the roots, are playful green wisps of light similar to those in the last room",
            "From where you stand you can just about make out a ledge far above you",
            "You may be able to use the roots to climb up there"
        };
        public static List<string> BeginClimb = new List<string>
        {
            "You step up the the closest root and press your weight against it to find it gives only slightly",
            "Carefully you climb on to the ancient wood and look up through the tangle of roots",
            "Its a long way up" ,
            "You look around to see there are to roots within jumping range of the one on which you stand",
            "One to the LEFT and another to the RIGHT"
        };
        public static List<string> JumpSuccess = new List<string>
        {
            "You launch yourself towards the root and manage to firmly grab hold of it",
            "You scramble yourself up on to it and look around for where to go next"
        };
        public static List<string> JumpSuccessButNextFail = new List<string>
        {
            "You jump towards the root and at the last minute, manage to catch it in your hands",
            "You lift your body and wrap your legs around the wood before hoisting yourself round and stand up",
            "You look around to see only one choice for your next jump"
        };
        public static List<string> JumpFail = new List<string>
        {
            "You leap forward to the root and wrap your hands around it",
            "As you try to lift yourself up on to it, you find the top is covered in a slimy layer of lychen",
            "You try to grip on however your hands slip and you fall in to the open air below you",
            "You tumble down and your fall is broken by the thick moss on the chamber floor",
            "You make your way over to the first root and climb back on, determined to try again"
        };
            //Maybe take small amount of damage and if hp gets to 0 you fail the whole dungeon
        public static List<string> JumpFailStage2 = new List<string>
        {
            "You leap forward to the root and wrap your hands around it",
            "As you try to lift yourself up on to it, you find the top is covered in a slimy layer of lychen",
            "You try to grip on however your hands slip and you fall in to the open air below you",
            "You tumble downwards but manage to catch hold of the small ledge to stop your fall",
            "You hoist yourself up and make your way along the ledge to the end where the two roots are, determined to try again"
        };
        public static List<string> NextIsLedge = new List<string>
        {
            "From where you stand you see that the ledge you saw earlier is within reach"
        };
        public static List<string> JumpToLedge = new List<string>
        {
            "You jump forward to the Ledge and your boots land on solid stone",
            "The ledge is narrow with only enough space for you and a large bundle of fabric to your left",
            "You lean down and pick up the strange item to find there is something wrapped within the old tattered cloth",
            "You pull the wrapping away to reveal a suspiciously well preserved wooden bow and a leather quiver of arrows",
            "Carved into the body of the bow you read the weapons name",
            "~~Featherflight~~",
            "You swing the quiver over your shoulder and he bow across your back and turn look out to the room of roots",
            "From your vantage point you see that the root platforms extend even higher up the room",
            "Near the ceiling you spy another stone outcropping which you can reach by climbing",
            "You shuffle along the small ledge to the end where there are two roots you could possibly jump to to make your way upwards"
        };
        public static List<string> ToSecondLedge = new List<string>
        {
            "You jump to the left root and as you are about to land on it, it vanishes revealing the large ledge",
            "You land hard on the stone and roll forward, coming to a stop against the chamber wall",
            "You stand up and dust yourself off, looking around",
            "You spot a small wooden chest tucked between the broken stones where the wall meets the platform and make your way towards it",
            "As you get closer, you hear chilling whispers and a sound like scratching on stone coming from somewhere below you",
            "You nervously peak over the edge of the outcropping to find the chamber below you still empty of anything alive",
            "Warily you head to the chest trying to ignore the haunting voices",
            "You pull the chest free from where sits and lift the lid to reveal a Bright Red gemstone, sitting inside, next to another 'Twisted Black Metal Shard",
            "The Red Gemstone seems to catch the light from the room and reflect it like flames burning within",
            "You reach in to retrieve the contents and as your hands touch the cold metal of the Twisted Shard, the disembodied whispers stop leaving an empty cold silence to fill the room",
            "You put the key and shard in your pack",
            "You look around for anything else but find nothing, so set about finding a way back down to the chamber floor"
        };
        public static List<string> LeaveSecondLedge = new List<string>
        {
            //Look around for a way down
            "You look around from your high perch for a possible way down and spot a thick, vertical root stretching downward at the far end of the ledge",
            "You make your way over to find it has a smaller root, wrapped round its entire length which you might use as a hand hold"
        };
        public static List<string> ClimbDown = new List<string>
        {
            "You grab hold of the smaller root and test its strength",
            "It is quite securely wrapped roound the larger, so you grab hold with both hands and swing yourself off of the ledge, finding purchase with your feet",
            "You begin the long climb down",
            "Half way to the chamber floor, your clothing catches on something and you swivel your head to see what it is",
            "From the cracked chamber walls, the small tip of a root pokes out, apparently awaiting a passing climbers clothes to tear",
            "More interestingly than the impish font, is what is hanging from it",
            "An old and tattered leather satchel, covered in small pockets and compartments swings loosely, just within reach"
        };
        public static List<string> LeatherSatchel = new List<string>
        {
            "You reach out carefully, gripping on tightly with the other hand, and coax the satchel from its wooden hook",
            "Resting it between the large root to which you cling and your other arm, you search through its many pockets",
            "The outer pockets contain what look like shrivelled up plant cuttings and a few broken glass vials",
            "You flip the bag open to look within its main inner compartment, and a glowing green wisp comes flying out, floating off and fading away",
            "Resting inside is a collection of old, rusted tools - a pair of broken shears, verious small metal rods with flat ends which could be for scraping, an old pair of scissors..",
            "Buried beneath however is a tightly bound Scroll, sealed with wax stamp depicting a tree, encircled with feathers",
            "You open the scroll to read it.."
        };
        public static List<string> ContinueDown = new List<string>
        {
            "You place the Scroll within your pack and continue making your way down to the ground below",
            "As you draw nearer to the bottom, you go to hook your foot on the small root below and find yourself stepping into open air",
            "You look down to find the root to which you cling veers sideways into a crack in the stone wall",
            "Beyong its sudden end, you can see the mossy floor below",
            "A distance of about 20 feet lies between you and your goal",
            "Theres only one choice. You ready yourself, securing your pack and.."
        };
        public static List<string> JumpToFloor = new List<string>
        {
            "You sail downwards through the air",
            "The ground rushes up to meet you and you land hard, bending your knees and rolling along the slightly damp floor, coming to rest on your back",
            "You lay there for a second looking up through the tangle of roots and notice the green wisps are no longer anywhere to be seen",
            "When your breath reaturns to you, you stand up and dust yourself off, ready to continue"
        };
        public static List<string> AlreadyClimbed = new List<string>
        {
            "You step out into the room and look towards the impossibly high ceiling",
            "After all the falling, you feel slightly sore, and would rather not go through it all again"
        };
        public static //Red Door
        List<string> RedDoor = new List<string>
        {
            "You make your way over to the Red door, your boots splashing through stagnant water as you go",
            "The door is impressively large and the rock surrounding it is carved in to sharp, crystal like points",
            "Accross the door, an image of a serpent has been molded into the metal spiraling outward, each scale carefully etched so it almost looks real"
        };
        public static List<string> TryRed = new List<string>
        {
            "The door is so large, you doubt you'd be able to push it open",
            "Nonetheless, you press your shoulder against it, your face pressed close to the head of the serpent, and push with all your strength",
            "Nothing, not even a creak",
            "Pressed so close now, you see in the centre of the door, where the serpents eye should be, sits only an empty space"
        };
        public static List<string> RedSerpent = new List<string>
        {
            "From your bag, you take out the 'Fiery Gemstone' and place it in to the serpents eye",
            "As it clicks in to place, you begin to feel heat radiating off of the door"  ,
            "The heat grows more intense and as you gaze upon it, the serpents eye blinks",
            "The great red serpent begins to move back and forth across the door, the metal rippling like liquid",
            "It winds its way up towards the top of the door, its long tail stretching all the way down behind it",
            "A sound like metal under a blacksmiths hammer rings out into the room as the very tip of the tail lifts itself off of the door, sticking out and bending to the side",
            "A handle?"
        };
        public static List<string> RedHandle = new List<string>
        {
            "You reach out and clasp your hand round the thick metal tail. It is warm to the touch",
            "You turn the handle and push the door, finding it gives way without much effort revealing darkness beyond"
        };
        public static List<string> LeaveGreen = new List<string>
        {
            "You step forward past the door, the gemstone twinkling above you",
            "Beyond you find a dark narrow corridor",
            "As you take a few steps forward, you hear a sound like the hiss of a snake, followed by a creak and then a loud bang",
            "You are plunged into darkness",
            "Running a hand along the wall to guide yourself, you make your way onwards to whatever lies ahead.."
        };
}
public static class RoomThree
{
    public static List<string> EnterRedRoom = new List<string>
    {
        "Through the darkness you march, hearing the sound of your boots on the stone below echoing off the dark walls",
        "In the distance you notice a gentle red glow breaking the darkness",
        "As you draw nearer and the light grows brighter, you hear the sound under foot change from a dull thud to a high pitch ring, like the sound of a glass bell",
        "You reach the glowing doorway and step through into the light",
        "You stand in a bright chamber that is narrow and stretches on quite far ahead of you",
        "In the stone walls, thousands of bright red glowing crystals stick out sharply at all angles",
        "The floor beneath your feet is no longer stone, but smooth flat and translucent red as if you are standing atop the face of a giant ruby",
        "You venture forward and find in the ground before you a massive hole stretching away from you to another ruby platform",
        "In the distant wall on the other platform, you can make out a black door",
        "Looking up you see four FLOATING CRYSTALS gently dipping and rising in the air just above the edge of the hole",
        "From left to right the crystals are YELLOW, PURPLE, ORANGE and WHITE",
        "Darting back and forth around the crystals with sharp, quick movements are bright red wisps of light"
    };
    public static List<string> InvestigateChasm = new List<string>
    {
        "You approach the edge of the chasm and look down into the darkness below",
        "There is no bottom in sight",
        "Looking accross to the cliff face on the other side, you see only smooth crystal rising out of the shadows",
        "You cannot see the cliff face on your side",
        "The distance accross is far too great to jump"
    };
    public static List<string> TryWall = new List<string>
    {
        "You walk over to the nearest wall hoping to find a path across",
        "The jutting out crystals spread all the way across the gap",
        "You make to test out gripping on to one and as your hand gets near, the crystal shrinks away back into the stone wall",
        "You cannot climb across"
    };
    public static List<string> InvestigateCrystals = new List<string>
    {
        "You move to just underneath the FLOATING CRYSTALS and inspect them more closely",
        "They are roughly the size of a small shield, each cut into a different shape",
        "The YELLOW crystal resembles an anvil with a hammer resting on its surface",
        "The PURPLE, a crescent moon",
        "The ORANGE, a rounded flame",
        "And the WHITE, a shield with a sword across it",
        "They are not too high in the air and you think you may be able to reach them if you jump"
    };
    public static List<string> JumpForCrystals = new List<string>
    {
        "You ready yourself and then spring upwards, stretching your hands out to try to grab hold of one of them",
        "As you rise up, the crystals react by floating higher in the air, evading your clutches",
        "You drop back down empty handed and notice on your outstretched hand, 'The Sorcerors Heart' has begun glowing bright white",
        "Perhaps magic can help you here.."  
    };
    public static List<string> WhichCrystal = new List<string>
    {
        "You look between the four crystals and decide it may be best to try your spell on the first on the left"
    };
    public static List<string> AttackFirstCrystal = new List<string>
    {
        "You set your sights on the YELLOW crystal and allow energy to flow through you from 'The Sorcerers Heart'",
        "You raise your hand and release a burst of magic at the crystal",
        "It hits the floating target making it glow bright yellow",
        "A rumble sounds from the great chasm in front of you and you look towards it to see two RUBY PLATFORMS rising from the shadows",
        "They come to a halt, level with the floor on which you stand, one directly at its edge and the other half way between the first and the other side",
        "You fire again at the YELLOW crystal and look on as the two platforms slowly drop back in to the shadows below"
    };
    public static string[] chasm = new string[] 
    { 
        "_____", 
        "_____", 
        "_____", 
        "_____" 
    };
    public static string platform = "|||||";
    public static string emptySpace = "_____";

    public static List<string> PuzzleComplete = new List<string>
    {
        "As the last platform lifts into place, giving you a clear path across the chasm, a shimmer runs across the walls of the chamber through every crystal",
        "The red wisps swirl round you and then dart out over the chasm, bobbing up and down over the platforms",
        "You make your way to the edge of the chasm and..."
    };
    public static List<string> PlatformOne = new List<string>
    {
        "..You jump over to the first platform",
        "Its slightly dips under your weight but then raises itself back up into position",
        "You shuffle gingerly to the far edge and.."
        
    };
    public static List<string> PlatformTwo = new List<string>
    {
        "..You hop to the next platform and feel again the ruby sink slightly before righting itself",
        "As you ready to jump to the next floating crystal you notice the red wisps spiraling over head",
        "From between the platform you stand on and the next, rises a clear flat crystal about as tall as you are",
        "It comes to a stop right in front of you and you see, encased within it, an ornate red GREAT SWORD as well as a GLOWING ORANGE PAGE and a small BLACK KEY"
    };
    public static List<string> PrizeCrystal = new List<string>
    {
        "You cast magic once more, aiming right at the large crystal and as the energy hits its surface, it shatters into pieces"  ,
        "The crystal shards fall away into the chasm, leaving behind the GREAT SWORD, the GLOWING PAGE and BLACK KEY suspended in the air before you"
    };
    public static List<string> RedSword = new List<string>
    {
        "You reach out and grasp the hilt of the GREAT SWORD",
        "The metal under your hand is warm and smooth and there is a sparkling ruby set into the pommel",
        "The guard is ornately molded to resemble twisting snakes with ruby eyes and sharp extended fangs",
        "You pull the sword from its scabbard to reveal a bright red metal blade with perilously sharp edges",
        "Inscribed down the flat of the blade is the weapons name",
        "~~~Serpents Fang~~~",
        "You afix the scabbard and sword to your belt"
    };
    public static List<string> GlowingPage = new List<string>
    {
        "You reach forward and take the GLOWING PAGE from where it floats",
        "You hold it gently, and read the text upon it",
        "- When night is far, no stars above",
        "- No shadows to protect from death",
        "- Cast forth a fiery beacon of",
        "- The fearsome serpents, 'Dragons Breath'",
        "As your eyes reach the last word, the scroll sets alight in your hands, the flames flowing like a serpent round your arm and then back up to your hand ",
        "The firey snake flows into 'The Sorcerors Heart' and is gone, leaving your arm burning from the inside"
    };
    public static List<string> BlackKey = new List<string>
    {
        "You reach out and take the PLAIN BLACK KEY",
        "As your hands wrap round the cold metal, all the light in the room flickers and dims",
        "From below you, deep in the chasm you hear the sound of something scraping against the crystal cliffs",
        "Rising from the depths, you hear once again the haunting, harsh cacophony of whispers growing closer",
        "A chill runs down your entire frame as the scraping sound gets louder and more furious"
    };
    public static List<string> RunToDoor = new List<string>
    {
        "Key still in hand, you hurriedly jump to the third platform, then the next and then finally to the other side of the chasm",
        "As your feet hit the crystal ground, the ruby platforms behind you crack and splinter before falling away",
        "The whispers are coming from all around now and the light coming from the walls is almost gone",
        "You race over to the BLACK DOOR and quickly put the 'Plain Black Key' into the key hole in its centre and turn it",
        "The key clicks in the lock, and then pushes itself back out into your hand",
        "You look down to see the 'Plain Black Key' morphing its shape, folding over and in on itself like thick tar",
        "The movements cease, leaving behind a gnarled, mess of metal which you quickly add to your pack"
    };
    public static List<string> EscapeRed = new List<string>
    {
        "In front of you the door groans as it swings away and you feel yourself being push forward into the dark corridor beyond",
        "You turn to see the red wisps, almost invisible now, urging you forward and soon you are through the doorway",
        "Darkness engulfs you as all light fades and the doorway behind you dissapears leaving behind a solid stone wall",
        "It is silent now but the memory of the scratching and whispering still echoes in your mind as you creep forward into the shadows.."
    };


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
        "--- Lord Kra..",
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