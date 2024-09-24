// See https://aka.ms/new-console-template for more information

using System.Diagnostics;
using PSP_PJInventory;

// Probando el programa
Character fran = new Character(Name: "Fran", MaxHitPoints: 20, BaseDamage: 20, BaseArmor:20);

Console.WriteLine($"${fran.Name}, mHP ${fran.MaxHitPoints}, cHP ${fran.CurrentHitPoints}, bDM ${fran.BaseDamage}," +
                  $" cDM ${fran.CurrentDamage}, bAM ${fran.BaseArmor}, cAM ${fran.CurrentArmor}");

fran.receibeDamage(10);

Axe axe = new Axe(20);
fran.AddToInventory(axe);

Shield shield = new Shield(20);
fran.AddToInventory(shield);

Console.WriteLine($"${fran.Name}, mHP ${fran.MaxHitPoints}, cHP ${fran.CurrentHitPoints}, bDM ${fran.BaseDamage}," +
                  $" cDM ${fran.CurrentDamage}, bAM ${fran.BaseArmor}, cAM ${fran.CurrentArmor}");


fran.removeFromInventory(axe);

Console.WriteLine($"${fran.Name}, mHP ${fran.MaxHitPoints}, cHP ${fran.CurrentHitPoints}, bDM ${fran.BaseDamage}," +
                  $" cDM ${fran.CurrentDamage}, bAM ${fran.BaseArmor}, cAM ${fran.CurrentArmor}");