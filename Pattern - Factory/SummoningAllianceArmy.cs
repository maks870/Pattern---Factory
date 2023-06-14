using System;

class SummoningAllianceArmy : ISummoningArmy
{
    public Mage[] SummonMages(int summonCount)
    {
        string name = "Phantom Alliance Mage";

        Mage[] mages = new Mage[summonCount];

        for (int i = 0; i < mages.Length; i++)
        {
            mages[i] = new AllianceMage(name);
        }

        Console.WriteLine($"Summon {name}. Count : {summonCount}");
        return mages;
    }

    public Range[] SummonRanges(int summonCount)
    {
        string name = "Phantom Alliance Range";

        Range[] ranges = new Range[summonCount];

        for (int i = 0; i < ranges.Length; i++)
        {
            ranges[i] = new AllianceRange(name);
        }

        Console.WriteLine($"Summon {name}. Count : {summonCount}");
        return ranges;
    }

    public Warrior[] SummonWarriors(int summonCount)
    {
        string name = "Phantom Alliance Warrior";

        Warrior[] warriors = new Warrior[summonCount];

        for (int i = 0; i < warriors.Length; i++)
        {
            warriors[i] = new AllianceWarrior(name);
        }

        Console.WriteLine($"Summon {name}. Count : {summonCount}");
        return warriors;
    }
}

