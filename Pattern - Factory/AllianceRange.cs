using System;

class AllianceRange : Range
{
    public AllianceRange(string name) : base(name)
    {
        race = "Light Elf";
        rank = "Forest bowman";
        this.name += " the child of Light";
    }

    public override void Equip()
    {
        base.Equip();
        Console.WriteLine($"Greatbow");
        Console.WriteLine($"Lembas");
    }

    public override void Trainig()
    {
        base.Trainig();
        Console.WriteLine("Small heal");
    }
}


