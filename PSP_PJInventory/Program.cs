// See https://aka.ms/new-console-template for more information

using System.Diagnostics;
using PSP_PJInventory;

// Probando el programa
Character fran = new Character("Fran",  20,  20, 20);

Console.WriteLine($"${fran.Name}, mHP ${fran.MaxHitPoints}, cHP ${fran.CurrentHitPoints}, bDM ${fran.BaseDamage}," +
                  $" cDM ${fran.CurrentDamage}, bAM ${fran.BaseArmor}, cAM ${fran.CurrentArmor}");

fran.ReceibeDamage(10);


Axe axe = new Axe(20,new Perk("Quemador", "Quema todo a su paso"));
fran.AddToInventory(axe);

Shield shield = new Shield(20,new Perk("Primer Golpe", "Te protege del primer golpe"));
fran.AddToInventory(shield);

Console.WriteLine($"${fran.Name}, mHP ${fran.MaxHitPoints}, cHP ${fran.CurrentHitPoints}, bDM ${fran.BaseDamage}," +
                  $" cDM ${fran.CurrentDamage}, bAM ${fran.BaseArmor}, cAM ${fran.CurrentArmor}");


fran.ShowPerks();

fran.RemoveFromInventory(axe);

Console.WriteLine($"${fran.Name}, mHP ${fran.MaxHitPoints}, cHP ${fran.CurrentHitPoints}, bDM ${fran.BaseDamage}," +
                  $" cDM ${fran.CurrentDamage}, bAM ${fran.BaseArmor}, cAM ${fran.CurrentArmor}");
                  
fran.ShowPerks();
