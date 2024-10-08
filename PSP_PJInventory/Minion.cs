namespace PSP_PJInventory;

public class Minion(string name, int damage)
{
    public int attack()
    {
        Console.WriteLine($"The minion {name} has attacked");
        return damage;
    }
}