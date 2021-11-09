using System;
using MyClassLib.WorldOfTanks;

namespace Day7_Tanks_
{
    class Program
    {
        static void Main(string[] args)
        {
            TanksGameplay.PlayMenu();

            //Tank[] T34 = new Tank[5];
            //T34[0] = new Tank("T-34 101");
            //T34[1] = new Tank("T-34 102");
            //T34[2] = new Tank("T-34 103");
            //T34[3] = new Tank("T-34 104");
            //T34[4] = new Tank("T-34 105");

            ////TanksGameplay.TankList(ref T34);
            ////Console.WriteLine();

            //Tank[] Pantera = new Tank[5];
            //Pantera[0] = new Tank("Pantera 601");
            //Pantera[1] = new Tank("Pantera 602");
            //Pantera[2] = new Tank("Pantera 603");
            //Pantera[3] = new Tank("Pantera 604");
            //Pantera[4] = new Tank("Pantera 605");

            ////TanksGameplay.TankList(ref Pantera);

            ////(T34[0] * Pantera[0]).Info();

            //int sumOfWinT34 = 0;
            //int sumOfWinPantera = 0;
            //for (int i = 0; i < T34.Length; i++)
            //{
            //    Console.ForegroundColor = ConsoleColor.Green;
            //    Console.WriteLine($"Battle #{i + 1}");
            //    Console.ResetColor();
            //    (T34[i] * Pantera[i]).Info();
            //    Console.WriteLine();
            //    sumOfWinT34 += T34[i].MyNuberOfWin;
            //    sumOfWinPantera += Pantera[i].MyNuberOfWin;
            //}
            //if(sumOfWinT34 > sumOfWinPantera)
            //{
            //    Console.ForegroundColor = ConsoleColor.Red;
            //    Console.WriteLine($"This battle is won by the T-34 team with a score of: {sumOfWinT34} - {sumOfWinPantera}");
            //    Console.ResetColor();
            //}
            //else
            //{
            //    Console.ForegroundColor = ConsoleColor.DarkBlue;
            //    Console.WriteLine($"This battle is won by the Pantera team with a score of: {sumOfWinPantera} - {sumOfWinT34}");
            //    Console.ResetColor();
            //}

            //Tank T35 = new Tank("T-35 401");
            //Tank Leopard = new Tank("Leopard III 601");
            //T35.Info();
            //Console.WriteLine();

            //Leopard.Info();
            //var a = Tank.IndividualBattle(ref T35, ref Leopard);
            //Console.ForegroundColor = ConsoleColor.Yellow;
            //Console.WriteLine($"\nThe winner at individual battle is:");
            //Console.ResetColor();

            //a.Info();
            //Console.WriteLine();

            //T35.Info();
            //Console.WriteLine();

            //Leopard.Info();

        }
    }
}
