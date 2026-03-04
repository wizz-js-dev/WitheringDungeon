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