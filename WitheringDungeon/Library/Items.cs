public class Item
{
    public string Name { get; set; }
    public string Description { get; set; }


    public Item(string name, string descr)
    {
        Name = name;
        Description = descr;
    }
}
public class UseableItem : Item
{
    public int Boost { get; set; }
    public string Attribute { get; set; }

    public UseableItem(string name, string descr, int boost, string attr) :base(name,descr)
    {
        Name = name;
        Description = descr;
        Boost = boost;
        Attribute = attr;
    }
}
public static class Items
{
    public static UseableItem DraughtVitality = new UseableItem("Draught of Vitality", "A small glass vial containing a swirling dark red liquid", 5, "health");
    public static UseableItem ElixirMagic = new UseableItem("Elixir of Magic", "A small glass vial containing a glittering blue liquid", 5, "mana");
    public static Item AncientRoot = new Item("Ancient Root","A small, piece of the root of some ancient tree. Petrified Moss clings to its surface");
    public static Item TwistedBlackShardOne = new Item("Twisted Black Metal Shard(1)","A sharp, gnarled piece of cold black metal. It makes you uncomfortable to look at it");
    public static Item TwistedBlackShardTwo = new Item("Twisted Black Metal Shard(2)","A sharp, gnarled piece of cold black metal. It seems to be repelled by the other shard in your pack");
    public static Item TwistedBlackShardThree = new Item("Twisted Black Metal Shardf(3)","A sharp, gnarled piece of cold black metal. You feel it almost calling out to you from your pack");
    public static Item FieryGemstone = new Item("Fiery Gemstone","A large roung ruby that looks like it has flames licking at its surface from within");
    public static Item PlainBlackKey = new Item("Plain Black Key","A simple black metal key");
}