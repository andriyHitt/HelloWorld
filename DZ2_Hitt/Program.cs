using System;

namespace DZ2_Hitt
{
    class Program
    {
        static void Main(string[] args)
        {
            Car Opel = new Car("Opel",2158.2, 10.5, 1.6, 110, 16, "Manual", "Dark grey", "Diesel");
            Opel.Info();
            Console.WriteLine();
            Console.WriteLine($"Cars Count is {DZ2_Hitt.Car.Count}"+'\n');

            Car[] cars = new Car[5];
            for(int i = 0; i < cars.Length; ++i)
            {
                cars[i] = new Car();
            }
            cars[0].Init("Opel",2158.2, 10.5, 1.6, 110, 16, "Manual", "Dark grey", "Diesel");
            cars[1].Init("Renault",2145.4, 10.5, 1.5, 75, 15, "Manual", "Brown", "Diesel");
            cars[2].Init("Mazda",1851.0, 11.0, 1.5, 80, 15, "Auto", "Red", "Petrol");
            cars[3].Init("Skoda",2140.2, 11.5, 1.9, 150, 16, "Manual", "White", "Petrol");
            cars[4].Init("Audi",2112.2, 12.3, 2.0, 180, 17, "Manual", "Dark grey", "Diesel");

            CarList.ListCars(ref cars);

            Console.WriteLine($"Cars Count is {DZ2_Hitt.Car.Count}" + '\n');
        }
    }
}
