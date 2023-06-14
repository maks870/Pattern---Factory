using System;

abstract class Soldier
{
    protected string name;
    protected string race;
    protected string rank;
    protected SoldierType type;

    public Soldier(string name)
    {
        this.name = name;
    }

    public void Prepare()
    {
        Console.WriteLine();
        Console.WriteLine($"New {type}: {rank} on the way!");
        Console.WriteLine($"Preparing {name} the {race} for spawn");
    }

    public virtual void Equip()
    {
        Console.WriteLine($"Equip {name} by:");
    }

    public virtual void Trainig()
    {
        Console.WriteLine($"Teach {rank} for new skill:");
    }
}

