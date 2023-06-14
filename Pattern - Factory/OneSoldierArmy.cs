using System;

class OneSoldierArmy : SummonedArmy
{
    public OneSoldierArmy(string name, ISummoningArmy summoningSpell) : base(name, summoningSpell)
    {
    }

    public override void SummonArmy()
    {
        SummonArmy(SoldierType.Warrior);
    }

    public void SummonArmy(SoldierType soldierType)
    {
        Console.WriteLine($"Summon оne {soldierType} soldier army : {name}");

        switch (soldierType)
        {
            case SoldierType.Warrior:
                warriors = summoningSpell.SummonWarriors(1);
                break;

            case SoldierType.Range:
                ranges = summoningSpell.SummonRanges(1);
                break;

            case SoldierType.Mage:
                mages = summoningSpell.SummonMages(1);
                break;
        }
    }
}


