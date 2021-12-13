using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClassLib.CarRacing
{
    public class CarRacingGameplay
    {
        public delegate void OnStart();
        
        public static void PlayMenu()
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("\nHello ! It's a game \"CAR RACING\".");
            Console.ResetColor();
            Console.WriteLine("\nLet's play.");

            char mainMenu = 'a';
            int playMenu = 1;
            int carMenu = 1;
            int racingMenu = 1;

            Car[] PassCar = new PassengerCar[5];
            PassCar[0] = new PassengerCar("Audi", 473.8, 140.0, 1.9, 150, 16, "Auto", "Black", "Diesel", 40, 213, 0, 4.4, "Wagon");
            PassCar[1] = new PassengerCar("BMW", 470.9, 140.1, 2.0, 258, 17, "Auto", "White", "Petrol", 59, 250, 0, 6.0, "Wagon");
            PassCar[2] = new PassengerCar("Opel", 470.2, 140.4, 1.6, 136, 16, "Manual", "Grey", "Diesel", 48, 212, 0, 4.5, "Wagon");
            PassCar[3] = new PassengerCar("Volkswagen", 456.7, 140.4, 2.0, 184, 17, "Manual", "Red", "Diesel", 50, 231, 0, 4.7, "Wagon");
            PassCar[4] = new PassengerCar("Renault", 462.6, 140.6, 1.3, 160, 17, "Manual", "Brown", "Petrol", 47, 208, 0, 5.2, "Wagon");

            Car[] SportsCar = new SportsCar[5];
            SportsCar[0] = new SportsCar("Hyundai", 403.5, 110, 3.0, 250, 17, "Manual", "Red&Black", "Petrol", 50, 250, 0, 6.0, "WRC");
            SportsCar[1] = new SportsCar("Toyota", 394.5, 110, 3.0, 250, 17, "Manual", "Red&White", "Petrol", 42, 250, 0, 6.0, "WRC");
            SportsCar[2] = new SportsCar("Ford", 406.5, 110, 3.0, 250, 17, "Manual", "Blue&White", "Petrol", 42, 250, 0, 6.0, "WRC");
            SportsCar[3] = new SportsCar("Citroen", 399.6, 110, 3.0, 250, 17, "Manual", "Red&Yelow", "Petrol", 45, 250, 0, 6.0, "WRC");
            SportsCar[4] = new SportsCar("Mini", 429.9, 110, 3.0, 250, 17, "Manual", "Red&Black", "Petrol", 51, 250, 0, 6.0, "WRC");

            Car[] Bus = new Bus[5];
            Bus[0] = new Bus("Man", 1185.7, 320, 6.9, 200, 22.5, "Auto", "Red", "Diesel", 300, 120, 0, 20.0, "City", 30);
            Bus[1] = new Bus("Ikarus", 1763.0, 330, 10.3, 258, 22, "Manual", "Yelow", "Diesel", 300, 75, 0, 25.2, "City", 25);
            Bus[2] = new Bus("Laz", 9980.0, 350, 11.1, 180, 22.5, "Manual", "White", "Diesel", 230, 113, 0, 25.0, "City", 41);
            Bus[3] = new Bus("Bogdan", 7430.0, 300, 4.6, 121, 17.5, "Manual", "Yelow", "Diesel", 100, 75, 0, 26.5, "City", 26);
            Bus[4] = new Bus("PAZ", 8165.0, 400, 4.7, 136, 19.5, "Manual", "White", "Diesel", 105, 65, 0, 31.0, "City", 30);

            Car[] Truck = new Truck[5];
            Truck[0] = new Truck("Scania", 3700.0, 400, 12.0, 380, 22.5, "Manual", "White", "Diesel", 600, 85, 0, 25.0, "Truck tractor", 12870);
            Truck[1] = new Truck("Renault", 3800.0, 410, 14.0, 400, 22.5, "Manual", "Red", "Diesel", 1200, 120, 0, 30.0, "Truck tractor", 18000);
            Truck[2] = new Truck("Man", 3750.0, 400, 13.5, 380, 22.5, "Manual", "Black", "Diesel", 1200, 120, 0, 26.0, "Truck tractor", 17000);
            Truck[3] = new Truck("Volvo", 3850.0, 400, 14, 420, 22.5, "Manual", "Green", "Diesel", 1600, 140, 0, 31.0, "Truck tractor", 20000);
            Truck[4] = new Truck("Mersedes", 3740.5, 400, 14.0, 380, 22.5, "Manual", "Pink", "Diesel", 1400, 140, 0, 28.0, "Truck tractor", 18000);


            do
            {
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine("\nGAMES MENU");
                Console.ResetColor();

                Console.WriteLine("a - cars race\n" +
                    "b - individual race (One to One)\n" +
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
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("\nThere are five cars take part in this game. \nThe car that finishes first  - wins.");

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

                        if (playMenu == 1)
                        {
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("\nChoose cars category:");
                            Console.ResetColor();
                            Console.WriteLine("1 - Passenger car\n" +
                                "2 - Sports car\n" +
                                "3 - Bus\n" +
                                "4 - Truck");
                            carMenu = Convert.ToInt32(Console.ReadLine());

                            try
                            {
                                if (carMenu < 1 || carMenu > 4)
                                {
                                    throw new Exception("\nInvalid menu item! try again!");
                                }
                            }
                            catch (Exception ex)
                            {
                                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                Console.WriteLine(ex.Message);
                                Console.ResetColor();
                                carMenu = Convert.ToInt32(Console.ReadLine());
                            }

                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("\nIt's a list of cars from categoty was you chose and that take part in race:");
                            Console.ResetColor();


                            if (carMenu == 1)
                            {
                                CarList(ref PassCar);
                                

                                //for (int i = 0; i < T34.Length; i++)
                                //{
                                //    Console.WriteLine($"Tank # {i + 1}:");
                                //    T34[i] = new Tank(Console.ReadLine());
                                //}

                            }
                            else if (carMenu == 2)
                            {
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.WriteLine("\nEnter tank's name one by one:");
                                Console.ResetColor();

                                //for (int i = 0; i < Pantera.Length; i++)
                                //{
                                //    Console.WriteLine($"Tank # {i + 1}:");
                                //    Pantera[i] = new Tank(Console.ReadLine());
                                //}

                            }

                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("\nDo you want to view yours team of tanks?");
                            Console.ResetColor();
                            Console.WriteLine("\nYES - 1\n" +
                                "NO - 0");
                            racingMenu = Convert.ToInt32(Console.ReadLine());

                            if (racingMenu == 1)
                            {
                                if (carMenu == 1)
                                {
                                    //TankList(ref T34);
                                }
                                //else TankList(ref Pantera);
                                Console.WriteLine();
                            }

                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine("\nInto battle!");
                            Console.ResetColor();
                            Console.ReadKey();

                            int sumOfWinT34 = 0;
                            int sumOfWinPantera = 0;

                            //for (int i = 0; i < T34.Length; i++)
                            //{
                            //    Console.ForegroundColor = ConsoleColor.DarkCyan;
                            //    Console.WriteLine($"Battle #{i + 1}");
                            //    Console.ResetColor();
                            //    Console.ForegroundColor = ConsoleColor.Red;
                            //    Console.WriteLine($"The winner is: {(T34[i] * Pantera[i]).MyTankname}");
                            //    Console.ResetColor();
                            //    //(T34[i] * Pantera[i]).Info();
                            //    TankVSTank(ref T34[i], ref Pantera[i]);
                            //    Console.WriteLine();
                            //    sumOfWinT34 += T34[i].MyNuberOfWin;
                            //    sumOfWinPantera += Pantera[i].MyNuberOfWin;
                            //}

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
                else if (mainMenu == 'b')
                {
                    do
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("\nEnter name of yours tank");
                        Console.ResetColor();
                        //Tank a = new Tank(Console.ReadLine());
                        //Tank b = new Tank("Tiger 666");

                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.WriteLine("\nTanks info:");
                        Console.ResetColor();
                        Console.WriteLine();

                        //a.Info();
                        //Console.WriteLine();
                        //b.Info();

                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("\nInto battle!");
                        Console.ResetColor();
                        Console.ReadKey();

                        //var c = Tank.IndividualBattle(ref a, ref b);

                        Console.ForegroundColor = ConsoleColor.Red;
                        //Console.WriteLine($"\nThe winner at individual battle is: {c.MyTankname}");
                        Console.ResetColor();

                        Console.ReadKey();

                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.WriteLine("\nTanks info after battle:");
                        Console.ResetColor();
                        Console.WriteLine();

                        //a.Info();
                        //Console.WriteLine();
                        //b.Info();

                        //TankVSTank(ref a, ref b);

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

        public static void CarList(ref Car[] cars)
        {
            foreach (Car car in cars)
            {
                car.Info();
                Console.WriteLine();
            }
        }

    }
}
