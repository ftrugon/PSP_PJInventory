using System.Security.Cryptography.X509Certificates;

namespace PSP_PJInventory;

public class Helmet:Protection
{
    public Helmet(int armor, Perk? perk = null)
    {
        Name = "Helmet";
        this.armor = armor;
        this.perk = perk;
    }
}