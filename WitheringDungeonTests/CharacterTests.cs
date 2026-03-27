namespace WitheringDungeonTests;

public class CharacterTests
{
    [Fact]
    public void Constructor_ShouldInitialiseAllFields()
    {
        Character wizz = new Character("wizz",20,"poison");
        Assert.Equal("wizz",wizz.Name);
        Assert.Equal(0,wizz.Attack);
        Assert.Equal(0,wizz.Defence);
        Assert.Equal(0,wizz.Speed);
        Assert.Equal(5,wizz.AttributePoints);
        Assert.Equal(0,wizz.Mana);
        Assert.Equal(20,wizz.Health);
        Assert.Equal("poison",wizz.Weakness);
        Assert.Equal(0,wizz.Evasiveness);
        Assert.IsType<List<Spell>>(wizz.SpellBook);
        Assert.Empty(wizz.SpellBook);
        Assert.IsType<List<Weapon>>(wizz.Equipped);
        Assert.Empty(wizz.Equipped);
        Assert.IsType<List<Item>>(wizz.Inventory);
        Assert.Empty(wizz.Inventory);
    }
    [Fact]
    public void PickUp_ShouldAddItemFromClassToInventory()
    {
        // Given
        Character wizz = new Character("wizz",20,"poison");
        // When
        wizz.PickUp(Items.ElixirMagic);
        // Then
        Assert.Single(wizz.Inventory);
        Assert.Equal("Elixir of Magic",wizz.Inventory[0].Name);
    }
    [Fact]
    public void Equip_ShouldAddWeaponFromClassToEquipped()
    {
        // Given
        Character wizz = new Character("wizz",20,"poison");
        // When
        wizz.Equip(Weapons.FeatherFlight);
        // Then
        Assert.Single(wizz.Equipped);
        Assert.Equal("Featherflight Bow",wizz.Equipped[0].Name);
    }
    [Fact]
    public void Learn_ShouldAddSpellFromClassToSpellBook()
    {
        // Given
        Character wizz = new Character("wizz",20,"poison");
    
        // When
        wizz.Learn(Spells.DragonsBreath);
    
        // Then
        Assert.Single(wizz.SpellBook);
        Assert.Equal("Dragon's Breath",wizz.SpellBook[0].Name);
    }
    [Fact]
    public void Restore_ShouldIncreaseStat()
    {
        // Given
        Character wizz = new Character("wizz",20,"poison");
        wizz.PickUp(Items.ElixirMagic);
        // When
        wizz.Restore(Items.ElixirMagic);
        // Then
        Assert.Equal(5,wizz.Mana);
    }
    [Fact]
    public void Restore_ShouldUseUpItem()
    {
        // Given
        Character wizz = new Character("wizz",20,"poison");
        wizz.PickUp(Items.ElixirMagic);
        // When
        wizz.Restore(Items.ElixirMagic);
        // Then
        Assert.Empty(wizz.Inventory);
    }
    //Comeback to below. I cant seem to figure it out
    //[Fact]
    // public void StatAssign_ShouldUpdateStats_BasedOnUserInput()
    // {
    //     // Given
    //     Character wizz = new Character("wizz",20,"poison");
    
    //     // When
    //     string inputString = $"2{Environment.NewLine}2{Environment.NewLine}1{Environment.NewLine}";
        
    //     StringReader inputReader = new StringReader(inputString);
    //     wizz.StatAssign(inputReader);
    
    //     // Then
    //     Assert.Equal(2,wizz.Attack);
    //     Assert.Equal(2,wizz.Defence);
    //     Assert.Equal(1,wizz.Speed);
    // }
}
