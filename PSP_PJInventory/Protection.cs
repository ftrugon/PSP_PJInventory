namespace PSP_PJInventory;

public abstract class Protection: Item
{
    
    public string Name;
    public int armor;
    
    public void Apply(Character character)
    {
        character.CurrentArmor += armor;
    }
}