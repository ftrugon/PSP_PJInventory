// See https://aka.ms/new-console-template for more information

using System.Diagnostics;
using PSP_PJInventory;

// Probando el programa
// crear el pj y poner por pantalla sus estadisticas
Character fran = new Character("Fran",  20,  20, 20);

Console.WriteLine($"${fran.Name}, mHP ${fran.MaxHitPoints}, cHP ${fran.CurrentHitPoints}, bDM ${fran.BaseDamage}," +
                  $" cDM ${fran.CurrentDamage}, bAM ${fran.BaseArmor}, cAM ${fran.CurrentArmor}");

// comprobacion que recibe bien el daño
fran.ReceibeDamage(10);


//añadiendo los items para ver que funciona
Axe axe = new Axe(20,new Perk("Quemador", "Quema todo a su paso",PerkType.BURN));
fran.AddToInventory(axe);

Shield shield = new Shield(20,new Perk("Minion Paco", "Invoca un minion",PerkType.MINION));
fran.AddToInventory(shield);

Console.WriteLine($"${fran.Name}, mHP ${fran.MaxHitPoints}, cHP ${fran.CurrentHitPoints}, bDM ${fran.BaseDamage}," +
                  $" cDM ${fran.CurrentDamage}, bAM ${fran.BaseArmor}, cAM ${fran.CurrentArmor}");

//muestra las perks de los items
fran.ShowPerks();

//Ataque del personaje y sus minions
Console.WriteLine(fran.Attack());

//probar a quitar un item del inventario
fran.RemoveFromInventory(axe);

Console.WriteLine($"${fran.Name}, mHP ${fran.MaxHitPoints}, cHP ${fran.CurrentHitPoints}, bDM ${fran.BaseDamage}," +
                  $" cDM ${fran.CurrentDamage}, bAM ${fran.BaseArmor}, cAM ${fran.CurrentArmor}");
                  
fran.ShowPerks();
