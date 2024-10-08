namespace PSP_PJInventory;

public class Minion(string name, int damage)
{
    public int attack()
    {
        Console.WriteLine($"The {name} has attacked");
        return damage;
    }
}