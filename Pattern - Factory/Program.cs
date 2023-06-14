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

            Console.WriteLine();
            Console.WriteLine("Командуем:");
            CommandBook commandBook = new AllianceCommandBook();

            commandBook.BattleCommand("White Wing", ArmyType.Balanced);
            Console.WriteLine();
            commandBook.BattleCommand("Sir Arthas", SoldierType.Warrior);
            Console.WriteLine();
            commandBook = new HordeCommandBook();
            commandBook.BattleCommand("Red mist Legion", ArmyType.Melee);
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}

