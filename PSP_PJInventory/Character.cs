using System.Security.Cryptography.X509Certificates;

namespace PSP_PJInventory;

public class Character(string name, int maxHitPoints, int baseDamage, int baseArmor)
{
    //Propiedades
    public string Name = name; 
    
    public int MaxHitPoints = maxHitPoints;
    public int CurrentHitPoints = maxHitPoints;
    
    public int BaseDamage = baseDamage;
    public int CurrentDamage = baseDamage;
    
    public int BaseArmor = baseArmor;
    public int CurrentArmor = baseArmor;
    
    private List<Item> _inventory = new();
    private List<Perk> _perks = new();
    
    //Metodos
    public int Attack()
    {
        return CurrentDamage;
    }

    public int Defense()
    {
        return CurrentArmor;
    }

    public void Heal(int amount)
    {
        if (CurrentHitPoints + amount > MaxHitPoints)
        {
            CurrentHitPoints = MaxHitPoints;
        }else if (CurrentHitPoints + amount < MaxHitPoints)
        {
            CurrentHitPoints += amount;
        }
    }

    public void ReceibeDamage(int amount)
    {
        CurrentHitPoints -= amount;
        if (CurrentHitPoints <= 0)
        {
            Console.WriteLine("The player has died!");
        }
    }

    private void ResetDamageAndArmor()
    {
        CurrentDamage = BaseDamage;
        CurrentArmor = BaseArmor;
    }

    private void ResetPerks()
    {
        _perks.Clear();
    }
    
    private void ApplyItems()
    {
        ResetDamageAndArmor();
        ResetPerks();
        foreach (var item in _inventory)
        {
            item.Apply(this);
            if (item.perk != null)
            {
                _perks.Add(item.perk);
            }
        }
    }
    
    public void AddToInventory(Item item)
    {
        _inventory.Add(item);
        ApplyItems();
    }

    public void RemoveFromInventory(Item item)
    {
        _inventory.Remove(item);
        ApplyItems();
    }
    
    
    public int InventoryCount() => _inventory.Count;


    public void ShowPerks()
    {
        
        Console.WriteLine();
        foreach (var perk in _perks)
        {
            Console.WriteLine($"{perk.Name} ---> {perk.Description}");
        }
        Console.WriteLine();
    }
}
