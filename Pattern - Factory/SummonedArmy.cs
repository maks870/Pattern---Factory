using System;

abstract class SummonedArmy
{
    protected string name;

    protected Warrior[] warriors;
    protected Range[] ranges;
    protected Mage[] mages;

    protected ISummoningArmy summoningSpell;
    public virtual void SummonArmy()
    {
        warriors = summoningSpell.SummonWarriors(5);
        ranges = summoningSpell.SummonRanges(5);
        mages = summoningSpell.SummonMages(5);
    }

    public SummonedArmy(string name, ISummoningArmy summoningSpell)
    {
        this.name = name;
        this.summoningSpell = summoningSpell;
    }

    public void GoToBattle()
    {
        Console.WriteLine($"{name} army go to battle!");
    }

    public void FightInBattle()
    {
        Console.WriteLine($"{name} army fighting in battle");
    }

    public void Retreat()
    {
        Console.WriteLine($"{name} army is retreating!");
    }

}

