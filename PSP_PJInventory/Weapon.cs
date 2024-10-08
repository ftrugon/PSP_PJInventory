namespace PSP_PJInventory;

public abstract class Weapon: Item
{
    
    public Perk? perk { get; set; }
    
    public string Name;
    public int damage;
    
    
    
    public void Apply(Character character)
    {
        character.CurrentDamage += damage;
    }

}