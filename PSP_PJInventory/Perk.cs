namespace PSP_PJInventory;

public class Perk(string name, string description, PerkType perkType)
{
    public string Name = name; 
    public string Description = description;

    public void Apply(Character character)
    {
        if (perkType == PerkType.MINION)
        {
            character.Minions.Add(new Minion($"{Name}",10));
        }else if (perkType == PerkType.BURN)
        {
            character.CurrentDamage += 10;
        }else if (perkType == PerkType.FIRST_STRIKE)
        {
            if (character.TimesHited == 1)
            {
                character.CurrentHitPoints = character.MaxHitPoints;
            }
        }
    }
}