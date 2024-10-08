namespace PSP_PJInventory;

public class Axe:Weapon
{
    public Axe(int damage, Perk? perk  = null)
    {
        Name = "Axe";
        this.damage = damage;
        this.perk = perk;
    }
}