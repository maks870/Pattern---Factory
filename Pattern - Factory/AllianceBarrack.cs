class AllianceBarrack : Barrack
{
    protected override Soldier CreateSoldier(string name, SoldierType type)
    {
        Soldier newSoldier = new AllianceWarrior(name);

        switch (type)
        {
            case SoldierType.Warrior:
                newSoldier = new AllianceWarrior(name);
                break;

            case SoldierType.Range:
                newSoldier = new AllianceRange(name);
                break;

            case SoldierType.Mage:
                newSoldier = new AllianceMage(name);
                break;
        }

        return newSoldier;
    }
}

