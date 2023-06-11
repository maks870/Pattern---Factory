abstract class Barrack
{
    public void SpawnSoldier(string name, SoldierType type)
    {
        Soldier soldier = CreateSoldier(name, type);
        soldier.Prepare();
        soldier.Equip();
        soldier.Trainig();
    }

    protected abstract Soldier CreateSoldier(string name, SoldierType type);
}

