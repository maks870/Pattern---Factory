using System;

class AllianceMage : Mage
{
    public AllianceMage(string name) : base(name)
    {
        race = "Dark Elf";
        rank = "Elemental sorcerer";
        this.name += " the child of Dark";
    }

    public override void Equip()
    {
        base.Equip();
        Console.WriteLine($"Сrystal staff");
        Console.WriteLine($"Bag of earth");
        Console.WriteLine($"Bag of fire bugs");
        Console.WriteLine($"Flask with water");
        Console.WriteLine($"Air whistle");
    }

    public override void Trainig()
    {
        base.Trainig();
        Console.WriteLine("Earthspike");
        Console.WriteLine("Fireball");
        Console.WriteLine("Waterwall");
        Console.WriteLine("Wind flow");
    }
}


