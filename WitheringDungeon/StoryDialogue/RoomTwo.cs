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