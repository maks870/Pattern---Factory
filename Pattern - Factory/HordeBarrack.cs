class HordeBarrack : Barrack
{
    protected override Soldier CreateSoldier(string name, SoldierType type)
    {
        Soldier newSoldier = new HordeWarrior(name);

        switch (type)
        {
            case SoldierType.Warrior:
                newSoldier = new HordeWarrior(name);
                break;

            case SoldierType.Range:
                newSoldier = new HordeRange(name);
                break;

            case SoldierType.Mage:
                newSoldier = new HordeMage(name);
                break;
        }

        return newSoldier;
    }
}

