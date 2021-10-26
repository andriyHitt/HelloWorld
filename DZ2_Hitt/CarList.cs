using System;
using System.Collections.Generic;
using System.Text;

namespace DZ2_Hitt
{
    public static class CarList
    {
        public static void ListCars(ref Car[] car)
        {
            foreach (Car car1 in car)
            {
                car1.Info();
                Console.WriteLine();
            }
        }
    }
}
