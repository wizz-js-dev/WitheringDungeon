
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