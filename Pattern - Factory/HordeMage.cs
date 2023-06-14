using System;

class HordeMage : Mage
{
    private string weapon;
    private string spell;

    public HordeMage(string name) : base(name)
    {
        Random rand = new Random();
        int choice = rand.Next(0, 4);
        switch (choice)
        {
            case 0:
                race = "Green Troll";
                rank = "Forest shaman";
                weapon = "Oak wand";
                spell = "Life-giving growth";
                this.name = "Woody " + this.name;
                break;

            case 1:
                race = "Blue Troll";
                rank = "Sky shaman";
                weapon = "Eye of thunder";
                spell = "Electric charge";
                this.name = "Storm " + this.name;
                break;

            case 2:
                race = "Brown Troll";
                rank = "Mud shaman";
                weapon = "Earth stones";
                spell = "Earth protection";
                this.name = "Dirty " + this.name;
                break;

            case 3:
                race = "Red Troll";
                rank = "Blood shaman";
                weapon = "Ritual dagger";
                spell = "Bloodlust";
                this.name = "Blood " + this.name;
                break;
        }
    }

    public override void Equip()
    {
        base.Equip();
        Console.WriteLine($"{weapon}");
    }

    public override void Trainig()
    {
        base.Trainig();
        Console.WriteLine($"{spell}");
    }
}


