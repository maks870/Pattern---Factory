using System;

class AllianceRange : Soldier
{
    public AllianceRange(string name) : base(name)
    {
        race = "Light Elf";
        type = "Forest bowman";
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


