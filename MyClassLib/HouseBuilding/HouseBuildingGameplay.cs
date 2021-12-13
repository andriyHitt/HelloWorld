using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClassLib.HouseBuilding
{
    public class HouseBuildingGameplay
    {
        public static void Menu()
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("\nHello ! It's a game \"HOUSE BUILDING\".");
            Console.ResetColor();
            Console.WriteLine("\nLet's build.");

            char mainMenu;
            ushort playMenu = 1;
            ushort toChekProcess = 0;

            ushort numbOfWorkers;
            uint currentProcessTime = 1; // поточний час процесу будівництва

            do
            {
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine("\nGAMES MENU");
                Console.ResetColor();

                Console.WriteLine("a - project on received assignment\n" +
                    "b - custom project\n" +
                    "x - EXIT");
                mainMenu = Convert.ToChar(Console.ReadLine());

                try
                {
                    if (mainMenu != 'a' && mainMenu != 'b' && mainMenu != 'x')
                    {
                        throw new Exception("\nInvalid menu item! Try again!");
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
                        playMenu = Convert.ToUInt16(Console.ReadLine());

                        try
                        {
                            if (playMenu > 1)
                            {
                                throw new Exception("\nInvalid menu item! Try again!");
                            }
                        }
                        catch (Exception ex)
                        {
                            Console.ForegroundColor = ConsoleColor.DarkMagenta;
                            Console.WriteLine(ex.Message);
                            Console.ResetColor();
                            playMenu = Convert.ToUInt16(Console.ReadLine());
                        }

                        if (playMenu == 1)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("\nYour mission it's a build hous with next parameters:");
                            Console.ResetColor();
                            Console.WriteLine("1 - basement;\n" +
                                "4 - walls;\n" +
                                "1 - roof;\n" +
                                "4 - windows;\n" +
                                "1 - door.");
                            
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("\nEnter the roster of building team from 2 to 10 workers:");
                            Console.ResetColor();
                            numbOfWorkers = Convert.ToUInt16(Console.ReadLine());

                            try
                            {
                                if (numbOfWorkers < 2 && numbOfWorkers > 10)
                                {
                                    throw new Exception("\nInvalid menu item! Try again!");
                                }
                            }
                            catch (Exception ex)
                            {
                                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                Console.WriteLine(ex.Message);
                                Console.ResetColor();
                                numbOfWorkers = Convert.ToUInt16(Console.ReadLine());
                            }

                            Team team = new Team(numbOfWorkers);
                            House house = new House(4, 4, 1);

                            for(int i = 0; i < Enum.GetValues(typeof(HouseParts)).Length; i++)
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine($"\n{Enum.GetValues(typeof(Periods)).GetValue(i)} STAGE:");
                                Console.ForegroundColor = ConsoleColor.DarkBlue;
                                Console.WriteLine($"Current day is {currentProcessTime}");

                                if (i != 0)
                                {
                                    Console.ForegroundColor = ConsoleColor.Yellow;
                                    Console.WriteLine("\nBefore build starting, let's chek was ended previos part of house");
                                    Console.ResetColor();
                                    Console.WriteLine("Press any key for cheking");
                                    Console.ReadKey();

                                    Console.ForegroundColor = ConsoleColor.Yellow;

                                    if (i == 1)
                                    {
                                        if (house.MyBasement.IsFinished)
                                        {
                                            Console.WriteLine("\nBuild Basement is ended");
                                        }
                                        else
                                            Console.WriteLine("\nBuild Basement is NOT ended");
                                    }
                                    else if (i == 2)
                                    {
                                        ushort j = 0;
                                        while (j < house.MyWalls.Length)
                                        {
                                            if (house.MyWalls[j].IsFinished)
                                            {
                                                Console.WriteLine($"Build wall #{j+1} is ended");
                                            }
                                            else
                                                Console.WriteLine($"Build wall #{j+1} is NOT ended");
                                            j++;
                                        }
                                    }
                                    else if (i == 3)
                                    {
                                        if (house.MyRoof.IsFinished)
                                        {
                                            Console.WriteLine("Build Roof is ended");
                                        }
                                        else
                                            Console.WriteLine("Build Roof is NOT ended");
                                    }
                                    else if (i == 4)
                                    {
                                        ushort l = 0;
                                        while (l < house.MyWindows.Length)
                                        {
                                            if (house.MyWindows[l].IsFinished)
                                            {
                                                Console.WriteLine($"Build window #{l+1} is ended");
                                            }
                                            else
                                                Console.WriteLine($"Build window #{l+1} is NOT ended");
                                            l++;
                                        }
                                    }
                                }
                                Console.ResetColor();

                                Console.ForegroundColor = ConsoleColor.DarkYellow;
                                Console.WriteLine($"\n{Enum.GetValues(typeof(HouseParts)).GetValue(i)} start building");
                                Console.ResetColor();

                                Console.ReadKey();

                                Console.Write($"\nFor build {Enum.GetValues(typeof(HouseParts)).GetValue(i)} according " +
                                    $"to the project has need ");

                                if (i == 0)
                                {
                                    Console.WriteLine($"{house.MyBasement.timeOfBuildProgress((ushort)team.MyWorkers.Length)} days");

                                    house.MyBasement.BuildProgress(ref team.workers());
                                    house.MyProgress += (ushort)(100 / Enum.GetValues(typeof(HouseParts)).Length);
                                    currentProcessTime += house.MyBasement.timeOfBuildProgress((ushort)team.MyWorkers.Length);
                                }
                                else if (i == 1)
                                {
                                    Console.WriteLine($"{house.MyWalls[0].timeOfBuildProgress((ushort)team.MyWorkers.Length) * house.MyWalls.Length} days");
                                    
                                    for(ushort k = 0; k < house.MyWalls.Length; k++)
                                    {
                                        Console.WriteLine($"\nBuild wall #{k + 1}:");
                                        
                                        house.MyWalls[k].BuildProgress(ref team.workers());
                                    }
                                    house.MyProgress += (ushort)(100 / Enum.GetValues(typeof(HouseParts)).Length);
                                    currentProcessTime += (uint)(house.MyWalls[0].timeOfBuildProgress((ushort)team.MyWorkers.Length) * house.MyWalls.Length);
                                }
                                else if (i == 2)
                                {
                                    Console.WriteLine($"{house.MyRoof.timeOfBuildProgress((ushort)team.MyWorkers.Length)} days");
                                    house.MyRoof.BuildProgress(ref team.workers());
                                    house.MyProgress += (ushort)(100 / Enum.GetValues(typeof(HouseParts)).Length);
                                    currentProcessTime += house.MyRoof.timeOfBuildProgress((ushort)team.MyWorkers.Length);

                                }
                                else if (i == 3)
                                {
                                    Console.WriteLine($"{house.MyWindows[0].timeOfBuildProgress((ushort)team.MyWorkers.Length) * house.MyWindows.Length} days");
                                    for (ushort k = 0; k < house.MyWindows.Length; k++)
                                    {
                                        Console.WriteLine($"\nBuild window #{k + 1}:");
                                        house.MyWindows[k].BuildProgress(ref team.workers());
                                    }
                                    house.MyProgress += (ushort)(100 / Enum.GetValues(typeof(HouseParts)).Length);
                                    currentProcessTime += (uint)(house.MyWindows[0].timeOfBuildProgress((ushort)team.MyWorkers.Length) * house.MyWindows.Length);

                                }
                                else if (i == 4)
                                {
                                    Console.WriteLine($"{(ushort)(house.MyDoors[0].timeOfBuildProgress((ushort)team.MyWorkers.Length) * house.MyDoors.Length)} days");
                                    for (ushort k = 0; k < house.MyDoors.Length; k++)
                                    {
                                        Console.WriteLine($"\nBuild door #{k + 1}:");
                                        house.MyDoors[k].BuildProgress(ref team.workers());
                                    }
                                    house.MyProgress += (ushort)(100 / Enum.GetValues(typeof(HouseParts)).Length);
                                    currentProcessTime += (uint)(house.MyDoors[0].timeOfBuildProgress((ushort)team.MyWorkers.Length) * house.MyDoors.Length);

                                }


                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.WriteLine("\nDo yoy want to did cheking of process to the house building and get report ?");
                                Console.ResetColor();
                                Console.WriteLine("YES- 1\n" +
                                    "NO - 0");
                                toChekProcess = (ushort)Convert.ToInt32(Console.ReadLine());
                                if (toChekProcess == 1)
                                {
                                    team.MyTeamLeader.isWorking = true;
                                    team.MyTeamLeader.Work();
                                    Console.WriteLine();
                                    Console.ReadKey();
                                    team.MyTeamLeader.Report(ref house);
                                    team.MyTeamLeader.isWorking = false;
                                }
                            }


                            playMenu = 0;
                        }
                    } while (playMenu != 0);
                }
                else if (mainMenu == 'b')
                {
                    do
                    {
                    } while (playMenu != 0);
                }

            } while (mainMenu != 'x');

        }

    }
}
