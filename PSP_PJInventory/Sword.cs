namespace PSP_PJInventory;

public class Sword:Weapon
{
    public Sword(int damage, Perk? perk = null)
    {
        Name = "Sword";
        this.damage = damage;
        this.perk = perk;
    }
}