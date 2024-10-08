namespace PSP_PJInventory;

public interface Item
{
    Perk? perk { get; set; }

    void Apply(Character character);
    
    
}