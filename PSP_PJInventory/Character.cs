namespace PSP_PJInventory;

public class Character
{
    //Propiedades
    public string Name; 
    
    public int MaxHitPoints;
    public int CurrentHitPoints;
    
    public int BaseDamage;
    public int CurrentDamage;
    
    public int BaseArmor;
    public int CurrentArmor;
    
    private List<Item> _inventory;
    
    //Constructor de la clase
    public Character(string Name, int MaxHitPoints, int BaseDamage, int BaseArmor)
    {
        this.Name = Name;
        this.MaxHitPoints = MaxHitPoints;
        CurrentHitPoints = MaxHitPoints;
        this.BaseDamage = BaseDamage;
        CurrentDamage = BaseDamage;
        this.BaseArmor = BaseArmor;
        CurrentArmor = BaseArmor;
        _inventory = new List<Item>();
    }
    
    public int Attack()
    {
        return BaseDamage;
    }

    public int Defense()
    {
        return BaseArmor;
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

    public void receibeDamage(int amount)
    {
        CurrentHitPoints -= amount;
        if (CurrentHitPoints <= 0)
        {
            Console.WriteLine("The player has died!");
        }
    }

    private void resetDamageAndArmor()
    {
        CurrentDamage = BaseDamage;
        CurrentArmor = BaseArmor;
    }
    
    private void applyItems()
    {
        resetDamageAndArmor();
        foreach (var item in _inventory)
        {
            item.Apply(this);
        }
    }
    
    public void AddToInventory(Item item)
    {
        _inventory.Add(item);
        applyItems();
    }

    public void removeFromInventory(Item item)
    {
        _inventory.Remove(item);
        applyItems();
    }
    
    
    public int InventoryCount() => _inventory.Count;
}
