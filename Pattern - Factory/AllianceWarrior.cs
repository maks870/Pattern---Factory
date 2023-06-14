using System;

class AllianceWarrior : Warrior
{
    public AllianceWarrior(string name) : base(name)
    {
        race = "Human";
        rank = "Holy knight";
        this.name = "Sir " + this.name;
    }

    public override void Equip()
    {
        base.Equip();
        Console.WriteLine($"Sword of light");
        Console.WriteLine($"Divine shield");
    }

    public override void Trainig()
    {
        base.Trainig();
        Console.WriteLine("Divine Barrier");
    }
}


