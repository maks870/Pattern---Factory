using System;

class HordeRange : Soldier
{
    public HordeRange(string name) : base(name)
    {
        race = "Goblin";
        type = "Gobgunner";
        this.name += "'gl";
    }

    public override void Equip()
    {
        base.Equip();
        Console.WriteLine($"Rusty hand cannon");
        Console.WriteLine($"Explosive ball");
    }

    public override void Trainig()
    {
        base.Trainig();
        Console.WriteLine("Shameful flight");
    }
}


