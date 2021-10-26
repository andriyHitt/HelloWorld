using System;
using System.Collections.Generic;
using System.Text;

namespace DZ2_Hitt
{
    public partial class Car
    {
        public void Info()
        {
            Console.WriteLine($"Car brand: {_carBrand}" + '\n' + $"Lenth: {_length}" + '\n' + $"Clearance: {_clearance}" + '\n' 
                + $"Engine displacement: {_engineDisplacement}" + '\n' + $"Engine power: {_enginePower}" + '\n' + $"Wheel diameter: {_wheelDiameter}" 
                + '\n' + $"Transmission: {_transmission}" + '\n' + $"Color: {_color}" + '\n' + $"Type of Fuel: {_typeOfFuel}");
        }
    }
}
