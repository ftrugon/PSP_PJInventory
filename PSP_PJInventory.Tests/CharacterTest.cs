using System.Collections.Generic;
using JetBrains.Annotations;
using PSP_PJInventory;
using Xunit;

namespace PSP_PJInventory.Tests;

[TestSubject(typeof(Character))]
public class CharacterTest
{
    
    // test constants
    private const string TestName = "TestName";
    private const int MaxHp = 20;
    private const int TestHp = 15;

    // test variables
    private Character _character;
    private int _testItems;
    private readonly List<Character> _characters = new List<Character>(); // just for dispose example
    
    public CharacterTest()
    {
        // test constructor, arrange data for every test.
        // every test method generates a new CharacterTest object.
        _character = new Character(TestName, MaxHp, 10,20);
        _characters.Add(_character);
        _character.AddToInventory(new Axe(5));
        _character.AddToInventory(new Sword(5));
        _character.AddToInventory(new Helmet(5));
        _character.AddToInventory(new Shield(5));
        _testItems = 4;
    }

    public void Dispose()
    {
        _characters.Clear();
    }

    [Fact]
    public void CharactersTest()
    {
        // test character list
        Assert.Single(_characters);
    }
    
    [Fact]
    public void NameTest()
    {
        // test character name
        Assert.Equal(TestName, _character.Name);
    }
    
    [Fact]
    public void HpTest()
    {
        // test maxhp
        Assert.Equal(MaxHp, _character.MaxHitPoints);
        _character = new Character(TestName, TestHp,20,20);
        Assert.Equal(TestHp, _character.MaxHitPoints);
    }

    [Fact]
    public void InventoryTest()
    {
        // test inventory
        Assert.Equal(_testItems, _character.InventoryCount());
        Assert.Equal(5 + 5 + _character.BaseDamage, _character.Attack());
        Assert.Equal(5 + 5 + _character.BaseArmor, _character.Defense());
        var newItem = new Axe(5);
        _character.AddToInventory(newItem);
        Assert.Equal(5, _character.InventoryCount());
        Assert.Equal(5*2 + 5 + _character.BaseDamage, _character.Attack());
        _character.removeFromInventory(newItem);
        Assert.Equal(4, _character.InventoryCount());
        Assert.Equal(5 + 5 + _character.BaseDamage, _character.Attack());
        _character.AddToInventory(new Shield(5));
        Assert.Equal(5*2 + 5 + _character.BaseArmor, _character.Defense());
    }
    
    [Fact]
    public void HealthTest()
    {
        // test heal/receive damage
        _character.receibeDamage(5);
        Assert.Equal(15, _character.CurrentHitPoints);
        _character.Heal(10);
        Assert.Equal(20, _character.CurrentHitPoints);
    }

}