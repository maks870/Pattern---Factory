using System;

class HordeWarrior : Warrior
{
    public HordeWarrior(string name) : base(name)
    {
        race = "Orc";
        rank = "Ogrimm Grinder";
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


