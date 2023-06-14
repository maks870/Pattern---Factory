class AllianceCommandBook : CommandBook
{
    public override SummonedArmy CreateArmy(string armyName, ArmyType type)
    {
        SummonedArmy army = null;

        ISummoningArmy summonSpell = new SummoningAllianceArmy();

        switch (type)
        {
            case ArmyType.Balanced:
                army = new BalancedArmy(armyName, summonSpell);
                break;

            case ArmyType.Melee:
                army = new MeleeArmy(armyName, summonSpell);
                break;

            case ArmyType.Range:
                army = new RangeArmy(armyName, summonSpell);
                break;

            case ArmyType.OneSoldier:
                army = new OneSoldierArmy(armyName, summonSpell);
                break;

        }

        return army;
    }
}


