namespace PSP_PJInventory;

public class Shield:Protection
{
    public Shield(int armor,Perk? perk = null)
    {
        Name = "Shield";
        this.armor = armor;
        this.perk = perk;
    }
}