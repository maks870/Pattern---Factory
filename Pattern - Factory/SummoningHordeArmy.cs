using System;

class SummoningHordeArmy : ISummoningArmy
{
    public Mage[] SummonMages(int summonCount)
    {
        string name = "Phantom Horde Mage";

        Mage[] mages = new Mage[summonCount];

        for (int i = 0; i < mages.Length; i++)
        {
            mages[i] = new HordeMage(name);
        }

        Console.WriteLine($"Summon {name}. Count : {summonCount}");
        return mages;
    }

    public Range[] SummonRanges(int summonCount)
    {
        string name = "Phantom Horde Range";

        Range[] ranges = new Range[summonCount];

        for (int i = 0; i < ranges.Length; i++)
        {
            ranges[i] = new HordeRange(name);
        }

        Console.WriteLine($"Summon {name}. Count : {summonCount}");
        return ranges;
    }

    public Warrior[] SummonWarriors(int summonCount)
    {
        string name = "Phantom Horde Warrior";

        Warrior[] warriors = new Warrior[summonCount];

        for (int i = 0; i < warriors.Length; i++)
        {
            warriors[i] = new HordeWarrior(name);
        }

        Console.WriteLine($"Summon {name}. Count : {summonCount}");
        return warriors;
    }
}

