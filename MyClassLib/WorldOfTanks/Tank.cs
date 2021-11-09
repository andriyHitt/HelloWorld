using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClassLib.WorldOfTanks
{
    public class Tank
    {
        private string _name;
        private int _ammunitionLevel;
        private int _armourLevel;
        private int _levelOfManoeuvrability;
        readonly Random rand = new Random();
        private int _numbOfWin;
        public Tank(string name) 
        {
            _name = name;
            _ammunitionLevel = rand.Next(0, 100);
            _armourLevel = rand.Next(0, 100);
            _levelOfManoeuvrability = rand.Next(0, 100);
            _numbOfWin = 0;
        }
        public void Info()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Tank name: {_name}");
            Console.ResetColor();
            Console.WriteLine($"Ammunition level: {_ammunitionLevel} %\n" +
                $"Armour level: {_armourLevel} %\n" +
                $"Level of manoeuvrability: {_levelOfManoeuvrability} %");
        }
        public string MyTankname { get => _name; }
        public string MyAmmunitionLevel { get=>_ammunitionLevel.ToString(); }
        public string MyArmourLevel { get=>_armourLevel.ToString(); }
        public string MyLevelOfManoeuvrability { get=>_levelOfManoeuvrability.ToString(); }

        public int ChangeAmmunition { get => _ammunitionLevel; set => _ammunitionLevel = value; }
        public int ChangeArmourLevel { get => _armourLevel; set => _armourLevel = value; }
        public int ChangeManoeuvrability { get => _levelOfManoeuvrability; set => _levelOfManoeuvrability = value; }
        public int MyNuberOfWin { get => _numbOfWin; set => _numbOfWin = value; }
        
        public static ref Tank IndividualBattle(ref Tank a, ref Tank b)
        {
            do
            {
                a.ChangeAmmunition = a.rand.Next(0, a._ammunitionLevel);
                b.ChangeAmmunition = b.rand.Next(0, b._ammunitionLevel);
                a.ChangeArmourLevel = a.rand.Next(0, a._armourLevel); 
                a.ChangeManoeuvrability = a.rand.Next(0, a._levelOfManoeuvrability);
                b.ChangeArmourLevel = b.rand.Next(0, b._armourLevel);
                b.ChangeManoeuvrability = b.rand.Next(0, b._levelOfManoeuvrability);
            } while (a._ammunitionLevel == b._ammunitionLevel && a._armourLevel == b._armourLevel && a._levelOfManoeuvrability == b._levelOfManoeuvrability);

            if (a._ammunitionLevel > b._ammunitionLevel && (a._armourLevel > b._armourLevel || a._levelOfManoeuvrability > b._levelOfManoeuvrability))
            {
                a.MyNuberOfWin = a._numbOfWin + 1;
                return ref a;
            }
            else 
            {
                b.MyNuberOfWin = b._numbOfWin + 1;
                return ref b;
            }
        }
        public static Tank operator*(Tank a, Tank b)
        {
            try
            {
                int victoryIdx = 0;

                victoryIdx = a._ammunitionLevel > b._ammunitionLevel ? victoryIdx += 1 : victoryIdx -= 1;
                victoryIdx = a._armourLevel > b._armourLevel ? victoryIdx += 1 : victoryIdx -= 1;
                victoryIdx = a._levelOfManoeuvrability > b._levelOfManoeuvrability ? victoryIdx += 1 : victoryIdx -= 1;

                if (victoryIdx > 0)
                {
                    a.MyNuberOfWin = a._numbOfWin + 1;
                    return a;
                }
                else if (victoryIdx < 0)
                {
                    b.MyNuberOfWin = b._numbOfWin + 1;
                    return b;
                }
                else
                {
                    throw new Exception("This time it's a draw, the result will show the individual battle");
                }
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine(ex.Message);
                Console.ResetColor();
                return IndividualBattle(ref a, ref b);
            }
        }
    }

    public static class TanksGameplay
    {
        public static void PlayMenu()
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Hello ! It's a game \"BATTLE OF TANKS\".");
            Console.ResetColor();
            Console.WriteLine("\nLet's play.");

            char mainMenu = 'a';
            int playMenu = 1;
            int tankMenu = 1;
            int battleMenu = 1;
            do
            {
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine("\nGAMES MENU");
                Console.ResetColor();

                Console.WriteLine("a - tank teams battle\n" +
                    "b - individual battle\n" +
                    "x - EXIT");
                mainMenu = Convert.ToChar(Console.ReadLine());

                try
                {
                    if (mainMenu != 'a' && mainMenu != 'b' && mainMenu != 'x')
                    {
                        throw new Exception("\nInvalid menu item! try again!");
                    }
                }
                catch (Exception ex)
                {
                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                    Console.WriteLine(ex.Message);
                    Console.ResetColor();
                    mainMenu = Convert.ToChar(Console.ReadLine());
                }


                if (mainMenu == 'a')
                {
                    do
                    {
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.WriteLine("\nPLAY MENU");
                        Console.ResetColor();
                        Console.WriteLine("1 - Go play\n" +
                            "0 - EXIT in main Menu");
                        playMenu = Convert.ToInt32(Console.ReadLine());

                        try
                        {
                            if (playMenu > 1)
                            {
                                throw new Exception("\nInvalid menu item! try again!");
                            }
                        }
                        catch (Exception ex)
                        {
                            Console.ForegroundColor = ConsoleColor.DarkMagenta;
                            Console.WriteLine(ex.Message);
                            Console.ResetColor();
                            playMenu = Convert.ToInt32(Console.ReadLine());
                        }
                        
                        if(playMenu == 1)
                        {
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("\nChoose tanks team:");
                            Console.ResetColor();
                            Console.WriteLine("1 - T-34\n" +
                                "2 - Pantera\n");
                            tankMenu = Convert.ToInt32(Console.ReadLine());

                            try
                            {
                                if (tankMenu != 1 && tankMenu != 2)
                                {
                                    throw new Exception("\nInvalid menu item! try again!");
                                }
                            }
                            catch (Exception ex)
                            {
                                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                Console.WriteLine(ex.Message);
                                Console.ResetColor();
                                tankMenu = Convert.ToInt32(Console.ReadLine());
                            }

                            Tank[] T34 = new Tank[5];
                            Tank[] Pantera = new Tank[5];

                            if (tankMenu == 1)
                            {
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.WriteLine("\nEnter tank's name one by one:");
                                Console.ResetColor();

                                for (int i = 0; i < T34.Length; i++)
                                {
                                    Console.WriteLine($"Tank # {i + 1}:");
                                    T34[i] = new Tank(Console.ReadLine());
                                }

                                Pantera[0] = new Tank("601");
                                Pantera[1] = new Tank("602");
                                Pantera[2] = new Tank("603");
                                Pantera[3] = new Tank("604");
                                Pantera[4] = new Tank("605");
                            }
                            else if (tankMenu == 2)
                            {
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.WriteLine("\nEnter tank's name one by one:");
                                Console.ResetColor();

                                for (int i = 0; i < Pantera.Length; i++)
                                {
                                    Console.WriteLine($"Tank # {i + 1}:");
                                    Pantera[i] = new Tank(Console.ReadLine());
                                }

                                T34[0] = new Tank("101");
                                T34[1] = new Tank("102");
                                T34[2] = new Tank("103");
                                T34[3] = new Tank("104");
                                T34[4] = new Tank("105");
                            }

                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("\nDo you want to view yours team of tanks?");
                            Console.ResetColor();
                            Console.WriteLine("\nYES - 1\n" +
                                "NO - 0");
                            battleMenu = Convert.ToInt32(Console.ReadLine());

                            if (battleMenu == 1)
                            {
                                if (tankMenu == 1)
                                {
                                    TankList(ref T34);
                                }
                                else TankList(ref Pantera);
                                Console.WriteLine();
                            }

                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine("\nInto battle!");
                            Console.ResetColor();
                            Console.ReadKey();

                            int sumOfWinT34 = 0;
                            int sumOfWinPantera = 0;

                            for (int i = 0; i < T34.Length; i++)
                            {
                                Console.ForegroundColor = ConsoleColor.DarkCyan;
                                Console.WriteLine($"Battle #{i + 1}");
                                Console.ResetColor();
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine($"The winner is: {(T34[i] * Pantera[i]).MyTankname}");
                                Console.ResetColor();
                                //(T34[i] * Pantera[i]).Info();
                                TankVSTank(ref T34[i], ref Pantera[i]);
                                Console.WriteLine();
                                sumOfWinT34 += T34[i].MyNuberOfWin;
                                sumOfWinPantera += Pantera[i].MyNuberOfWin;
                            }

                            if (sumOfWinT34 > sumOfWinPantera)
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine($"This battle is won by the T-34 team with a score of: {sumOfWinT34} - {sumOfWinPantera}");
                                Console.ResetColor();
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.DarkBlue;
                                Console.WriteLine($"This battle is won by the Pantera team with a score of: {sumOfWinPantera} - {sumOfWinT34}");
                                Console.ResetColor();
                            }

                            playMenu = 0;
                        }
                    } while (playMenu != 0);
                }
                else if(mainMenu == 'b')
                {
                    do
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("\nEnter name of yours tank");
                        Console.ResetColor();
                        Tank a = new Tank(Console.ReadLine());
                        Tank b = new Tank("Tiger 666");

                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.WriteLine("\nTanks info:");
                        Console.ResetColor();
                        Console.WriteLine();
                        
                        a.Info();
                        Console.WriteLine();
                        b.Info();
                        
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("\nInto battle!");
                        Console.ResetColor();
                        Console.ReadKey();

                        var c = Tank.IndividualBattle(ref a, ref b);

                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine($"\nThe winner at individual battle is: {c.MyTankname}");
                        Console.ResetColor();
                        
                        Console.ReadKey();

                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.WriteLine("\nTanks info after battle:");
                        Console.ResetColor();
                        Console.WriteLine();

                        //a.Info();
                        //Console.WriteLine();
                        //b.Info();

                        TankVSTank(ref a, ref b);

                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("\nNew battle ?");
                        Console.ResetColor();
                        Console.WriteLine("YES- 1\n" +
                            "NO - 0");
                        playMenu = Convert.ToInt32(Console.ReadLine());

                    } while (playMenu != 0);
                }

            } while (mainMenu != 'x');

        }
        public static void TankList(ref Tank[] tanks)
        {
            foreach (Tank tank in tanks)
            {
                tank.Info();
                Console.WriteLine();
            }
        }

        public static void TankVSTank(ref Tank a, ref Tank b)
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("\t\t\t\t\"T-34\" \t\tVS\t\t \"Pantera\"");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("Tank name: \t\t\t");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write($"{a.MyTankname}\t\t|\t\t{b.MyTankname}\n");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("Ammunition level: \t\t");
            Console.ResetColor();
            Console.Write($"{a.MyAmmunitionLevel}\t\t|\t\t{b.MyAmmunitionLevel}\n");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("Armour level: \t\t\t");
            Console.ResetColor();
            Console.Write($"{a.MyArmourLevel}\t\t|\t\t{b.MyArmourLevel}\n");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("Level of manoeuvrability: \t");
            Console.ResetColor();
            Console.Write($"{a.MyLevelOfManoeuvrability}\t\t|\t\t{b.MyLevelOfManoeuvrability}\n");
        }
    }

}
