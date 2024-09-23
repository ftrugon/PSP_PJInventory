namespace PSP_PJInventory;

public abstract class Weapon: Item
{

    public string Name;
    public int damage;
    
    public void Apply(Character character)
    {
        character.CurrentDamage += damage;
    }
}