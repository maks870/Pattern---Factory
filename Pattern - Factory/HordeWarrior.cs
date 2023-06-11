using System;

class HordeWarrior : Soldier
{
    public HordeWarrior(string name) : base(name)
    {
        race = "Orc";
        type = "Ogrimm Grinder";
        this.name += "'erk";
    }

    public override void Equip()
    {
        base.Equip();
        Console.WriteLine($"Bloody Axe");
        Console.WriteLine($"Spiked armor");
    }

    public override void Trainig()
    {
        base.Trainig();
        Console.WriteLine("Bone crusher");
    }
}


