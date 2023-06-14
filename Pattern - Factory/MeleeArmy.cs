using System;

class MeleeArmy : SummonedArmy
{
    public MeleeArmy(string name, ISummoningArmy summoningSpell) : base(name, summoningSpell)
    {
    }

    public override void SummonArmy()
    {
        Console.WriteLine($"Summon melee army : {name}");

        warriors = summoningSpell.SummonWarriors(20);
    }
}


