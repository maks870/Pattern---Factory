using System;

class BalancedArmy : SummonedArmy
{
    public BalancedArmy(string name, ISummoningArmy summoningSpell) : base(name, summoningSpell)
    {
    }

    public override void SummonArmy()
    {
        Console.WriteLine($"Summon balanced army : {name}");
        base.SummonArmy();
    }
}

abstract class CommandBook
{
    public void BattleCommand(string armyName, ArmyType type)
    {
        SummonedArmy army = CreateArmy(armyName, type);
        army.SummonArmy();
        army.GoToBattle();
        army.FightInBattle();
        army.Retreat();
    }

    public void BattleCommand(string armyName, SoldierType soldierType)
    {
        OneSoldierArmy army = (OneSoldierArmy)CreateArmy(armyName, ArmyType.OneSoldier);
        army.SummonArmy(soldierType);
        army.GoToBattle();
        army.FightInBattle();
        army.Retreat();
    }

    public abstract SummonedArmy CreateArmy(string armyName, ArmyType type);
}


