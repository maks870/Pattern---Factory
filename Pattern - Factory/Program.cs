using System;

namespace Pattern___Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            Barrack barrack = new AllianceBarrack();

            barrack.SpawnSoldier("Kven", SoldierType.Range);

            barrack = new HordeBarrack();

            barrack.SpawnSoldier("Gal", SoldierType.Mage);
            barrack.SpawnSoldier("Leg", SoldierType.Mage);
            barrack.SpawnSoldier("Rigl", SoldierType.Mage);
            barrack.SpawnSoldier("Tan", SoldierType.Warrior);
            Console.ReadKey();
        }
    }
}

