using System;

class RangeArmy : SummonedArmy
{
    public RangeArmy(string name, ISummoningArmy summoningSpell) : base(name, summoningSpell)
    {
    }

    public override void SummonArmy()
    {
        Console.WriteLine($"Summon range army : {name}");

        ranges = summoningSpell.SummonRanges(10);
        mages = summoningSpell.SummonMages(5);
    }
}


