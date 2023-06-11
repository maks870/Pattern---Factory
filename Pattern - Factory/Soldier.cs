using System;

abstract class Soldier
{
    protected string name;
    protected string race;
    protected string type;

    public Soldier(string name)
    {
        this.name = name;
    }

    public void Prepare()
    {
        Console.WriteLine();
        Console.WriteLine($"New {type} on the way!");
        Console.WriteLine($"Preparing {name} the {race} for spawn");
    }

    public virtual void Equip()
    {
        Console.WriteLine($"Equip {name} by:");
    }

    public virtual void Trainig()
    {
        Console.WriteLine($"Teach {type} for new skill:");
    }
}


